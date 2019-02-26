using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMyBru.GetMyBru.Core.Installer
{
    internal static class IServiceInstall
    {
        public static string ISystem;

        public static string AppToInstall;

        public static void CheckHomebrewSystem()

        {
            if (ISystem == "switch")
            {
                InstallSwitch();
            }
        }

        private static void InstallSwitch()
        {
            return;
        }

        private static void InstallWiiU()
        {
        }
    }
}