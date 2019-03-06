﻿using GetMyBru.GetMyBru.GUI;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMyBru.GetMyBru.Core.Installer
{
    internal static class IServiceInstall
    {
        public static string ISystem;

        private static WebClient GetPackage = new WebClient();
        private static string cd = Environment.CurrentDirectory;
        private static string URLStr;
        private static string Path;
        public static int PackageProgress;
        public static bool PackageDownloadComplete;
        public static double bytesIn;
        public static double totalBytes;
        public static double percentage;
        public static bool Installing;
        public static bool Installed;
        public static bool Downloading;

        public static void InstallSwitch(string AppToInstall)
        {
            try
            {
                Downloading = true;
                PackageDownloadComplete = false;
                PackageProgress = 0;
                Path = cd + "\\Data\\Cache\\Switch\\" + AppToInstall + ".zip";
                Uri URL = new Uri("https://www.switchbru.com/appstore/zips/" + AppToInstall + ".zip");
                CacheCheck.PerformCheck();
                URLStr = URL.ToString();
                GetPackage.DownloadProgressChanged += new DownloadProgressChangedEventHandler(PackageDownloadProgress);
                GetPackage.DownloadFileCompleted += new AsyncCompletedEventHandler(PackageDownloadedAsync);
                GetPackage.DownloadFileAsync(URL, Path);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "URL: " + URLStr, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Installing = false;
                Downloading = false;
                return;
            }
        }

        private static async Task ExtractPackageAsync()
        {
            try
            {
                using (ZipFile Package = ZipFile.Read(Path))
                {
                    if (File.Exists(Properties.Settings.Default.Drive + ":\\info.json") || File.Exists(Properties.Settings.Default.Drive + ":\\manifest.install"))
                    {
                        File.Delete(Properties.Settings.Default.Drive + ":\\info.json");
                        File.Delete(Properties.Settings.Default.Drive + ":\\manifest.install");
                    }
                    Package.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                    await Task.Run(() => Package.ExtractAll(Properties.Settings.Default.Drive + ":\\"));
                }
            }
            catch
            {
                Installed = true;
                Installing = false;
                return;
            }
            Installed = true;
            Installing = false;
            return;
        }

        public static void PackageDownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            bytesIn = double.Parse(e.BytesReceived.ToString());
            totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            percentage = bytesIn / totalBytes * 100;
            PackageProgress = int.Parse(Math.Truncate(percentage).ToString());
        }

        public static async void PackageDownloadedAsync(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Console.WriteLine("Package download failed");
            }
            else
            {
                Downloading = false;
                Installing = true;
                Console.WriteLine("Package downloaded");
                await ExtractPackageAsync();
            }
        }

        private static void InstallWiiU()
        {
            return;
        }
    }
}