﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMyBru.GetMyBru.Core.Net.Parser
{
    internal class BruParser
    {
        public static string PackagesRawList;
        private static string cd = Environment.CurrentDirectory;
        public static string PackagesRaw;

        public static void PrepareJSON()
        {
            try
            {
                if (!Directory.Exists(cd + "\\Data\\Cache\\Switch"))
                {
                    Directory.CreateDirectory(cd + "\\Data\\Cache\\Switch");
                }
                using (var JSONData = new WebClient())
                {
                    JSONData.DownloadFile("https://www.switchbru.com/appstore/repo.json", cd + "\\Data\\Cache\\Switch\\repo.json");
                }
             }
            catch (Exception ex)
            {
                Messagebox.Show("Error, exception is as follows: " + ex.Message, "Error:", MessageboxButtons.Ok, Messagebox.Icon.Error)
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
                Messagebox.Show("Error, exception is as follows: " + ex.Message, "Error:", MessageboxButtons.Ok, Messagebox.Icon.Error)
                return; 
            }
        }
    }
}
