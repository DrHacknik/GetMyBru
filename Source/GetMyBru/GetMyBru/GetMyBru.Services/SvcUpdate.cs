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

        public void GetUpdate()
        {
            using (var JSONData = new WebClient())
            {
                JSONData.DownloadFile("https://github.com/DrHacknik/GetMyBru/blob/master/Common/Updates/Meta.json", cd + "\\Data\\Cache\\Update\\Update.json");
            }
            ParseUpdate();
        }

        private void ParseUpdate()
        {
            using (StreamReader ReadJson = new StreamReader(cd + "\\Data\\Cache\\Update\\Update.json"))
            {
                string json = ReadJson.ReadToEnd();
                return;
            }
        }
    }
}