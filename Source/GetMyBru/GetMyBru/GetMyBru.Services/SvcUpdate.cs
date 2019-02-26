using GetMyBru.GetMyBru.GUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetMyBru.GetMyBru.Services
{
    internal class SvcUpdate
    {
        private static string cd = Environment.CurrentDirectory;
        private static string IPath = cd + "\\Data\\Cache\\Update\\Update.json";

        public static void GetUpdate()
        {
            try
            {
                using (var JSONData = new WebClient())
                {
                    Uri JSONURL = new Uri("https://github.com/DrHacknik/GetMyBru/raw/master/Common/Updates/Meta.json");
                    JSONData.DownloadFileAsync(JSONURL, IPath);
                }
                FmSelectSystem.NotifTitle = "GetMyBru - Update Check";
                FmSelectSystem.NotifText = "Loaded update Information";
                FmSelectSystem.NotifTime = 40000;
                FmSelectSystem.ShowToast = true;
                ParseUpdate();
            }
            catch (Exception ex)
            {
                FmSelectSystem.NotifTitle = "GetMyBru - Update Check";
                FmSelectSystem.NotifText = ex.Message;
                FmSelectSystem.NotifTime = 40000;
                FmSelectSystem.ShowToast = true;
                return;
            }
        }

        private static void ParseUpdate()
        {
            using (StreamReader ReadJson = new StreamReader(cd + "\\Data\\Cache\\Update\\Update.json"))
            {
                string json = ReadJson.ReadToEnd();
                return;
            }
        }
    }
}