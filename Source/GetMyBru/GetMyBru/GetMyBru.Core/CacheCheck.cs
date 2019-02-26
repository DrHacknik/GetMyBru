using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetMyBru.GetMyBru.Services;

namespace GetMyBru.GetMyBru.Core
{
    internal class CacheCheck
    {
        private static string cd = Environment.CurrentDirectory;

        public static void PerformCheck()
        {
            if (!Directory.Exists(cd + "\\Data"))
            {
                Directory.CreateDirectory(cd + "\\Data");
            }

            if (!File.Exists(cd + "\\Data\\Config.json"))
            {
                File.WriteAllText(cd + "\\Data\\Config.json", "{ }");
            }

            if (!Directory.Exists(cd + "\\Data\\Cache\\Switch"))
            {
                Directory.CreateDirectory(cd + "\\Data\\Cache\\Switch");
            }
            if (!Directory.Exists(cd + "\\Data\\Cache\\WiiU"))
            {
                Directory.CreateDirectory(cd + "\\Data\\Cache\\WiiU");
            }
            if (!Directory.Exists(cd + "\\Data\\Cache\\Wii"))
            {
                Directory.CreateDirectory(cd + "\\Data\\Cache\\Wii");
            }
            if (!Directory.Exists(cd + "\\Data\\Cache\\Update"))
            {
                Directory.CreateDirectory(cd + "\\Data\\Cache\\Update");
            }

            if (Properties.Settings.Default.AutoUpdate == true)
            {
                SvcUpdate.GetUpdate();
            }
            //if (Properties.Settings.Default.Clean == true)
            //{
            //    ClearCache(cd + "\\Data\\Cache\\");
            //}

            return;
        }

        private static void ClearCache(string CacheDir)
        {
            Directory.Delete(CacheDir, true);
            return;
        }
    }
}