﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMyBru.GetMyBru.Core
{
    internal class BruParser
    {
        public static string PackagesRawList;
        private static string cd = Environment.CurrentDirectory;
        private static string IPathWiiU = cd + "\\Data\\Cache\\WiiU\\repo.json";
        private static string IPathSwitch = cd + "\\Data\\Cache\\Switch\\repo.json";
        public static string PackagesRaw;
        public static string System;

        public static void PrepareJSON()
        {
            try
            {
                if (!Directory.Exists(cd + "\\Data\\Cache\\Switch"))
                {
                    Directory.CreateDirectory(cd + "\\Data\\Cache\\Switch");
                }

                if (System == "Switch")
                {
                    using (var JSONData = new WebClient())
                    {
                        Uri JSONURL = new Uri("https://www.switchbru.com/appstore/repo.json");
                        JSONData.DownloadFileAsync(JSONURL, IPathSwitch);
                    }
                }
                else if (System == "WiiU")
                {
                    using (var JSONData = new WebClient())
                    {
                        Uri JSONURL = new Uri("https://www.wiiubru.com/appstore/repo.json");
                        JSONData.DownloadFileAsync(JSONURL, IPathWiiU);
                    }
                }
                else if (System == "Wii")
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, exception is as follows: " + ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static void ParseJSONSwitch()
        {
            try
            {
                using (StreamReader ReadJson = new StreamReader(cd + "\\Data\\Cache\\Switch\\repo.json"))
                {
                    string json = ReadJson.ReadToEnd();
                    PackagesRawList = json;
                    //PackagesRaw = JsonConvert.DeserializeObject(json);
                }
                //dynamic Packages = JsonConvert.DeserializeObject(Environment.CurrentDirectory + "\\Data\\Cache\\Switch\\repo.json".ToString());
                //PackagesRawList = Packages.Packages;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, exception is as follows: " + ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}