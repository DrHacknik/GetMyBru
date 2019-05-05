using Ionic.Zip;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetMyBru.GetMyBru.GUI;
using System.Linq;

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
                if (Properties.Settings.Default.Drive == String.Empty)
                {
                    Core.ILogging.Output(true, false, false, false, "The Drive settings field has been left empty. Please configure this and try again.", true); 
                    MessageBox.Show("The Drive settings field has been left empty. Please configure this and try again.", "Error: No Drive set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form Fs = new FmSelectSystem();
                    Fs.Show();
                    FmSelectSystem.SettingsActive = true;
                    return;
                }
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
                Core.ILogging.Output(true, false, false, false, ex.Message, true); 
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
                if (Properties.Settings.Default.Drive == null)
                {
                    Core.ILogging.Output(true, false, false, false, "The Drive settings field has been left empty. Please configure this and try again.", true);
                    MessageBox.Show("The drive letter has not been configured. Please do so, then try again.", "Error: Invalid Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form _UISettings = new FmSelectSystem();
                    _UISettings.Show();
                    FmSelectSystem.SettingsActive = true;
                    return;
                }
                else
                {
                    using (ZipFile Package = ZipFile.Read(Path))
                    {
                        try
                        {
                            File.Delete(Properties.Settings.Default.Drive + ":\\*.json");
                            File.Delete(Properties.Settings.Default.Drive + ":\\*.install");
                            File.Delete(Properties.Settings.Default.Drive + ":\\*.tmp");
                        }
                        catch (Exception ex)
                        {
                            Core.ILogging.Output(true, false, false, false, ex.Message, true);
                            Installing = false;
                            Installed = true;
                            return;
                        }
                        await Task.Run(() => Package.ExtractAll(Properties.Settings.Default.Drive + ":\\", ExtractExistingFileAction.OverwriteSilently));
                    }
                    if (Properties.Settings.Default.Clean == true)
                    {
                        Directory.Delete(cd + "\\Data\\Cache\\Switch", true);
                    }
                    Installing = false;
                    Installed = true;
                }
            }
            catch
            {
                Installed = true;
                Installing = false;
                return;
            }
            return;
        }


        public static void PackageDownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            percentage = e.ProgressPercentage;
            PackageProgress = e.ProgressPercentage;
        }

        public static async void PackageDownloadedAsync(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Core.ILogging.Output(true, false, false, false, "Package download failed", true);
                Console.WriteLine("Package download failed");
                return; 
            }
            else
            {
                Downloading = false;
                Installing = true;
                Core.ILogging.Output(false, false, false, true, "Package downloaded", true);
                Core.ILogging.Output(false, false, false, true, "Package installing", true);
                await ExtractPackageAsync();
                return;
            }
        }

        private static void InstallWiiU()
        {
            return;
        }
    }
}
