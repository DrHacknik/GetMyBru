using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace GetMyBru.GetMyBru.Core.Config
{
    internal class ConfigParser
    {
        public static bool AutoUpdate;
        public static bool Branch;
        public static bool Clean;
        public static bool Notif;
        public static bool FirstTime;
        public static bool Drive;

        public static void CheckSettings()
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\GetMyBru.config"))
            {
                //try
                //{
                //    Configuration config = ConfigurationManager.OpenExeConfiguration(Environment.CurrentDirectory);
                //    AppConfig.Save(ConfigurationSaveMode.Minimal);

                //    config.AppSettings.Settings.Add(key, value);
                //    config.Save();
                //    ConfigurationManager.RefreshSection(sectionName);
                //}
                //catch (ConfigurationErrorsException e)
                //{
                //}
                return;
            }
            else
            {
                LoadSettings();
                return;
            }
        }

        public static void SaveSettings()
        {
            return;
        }

        public static void LoadSettings()
        {
            return;
        }
    }
}