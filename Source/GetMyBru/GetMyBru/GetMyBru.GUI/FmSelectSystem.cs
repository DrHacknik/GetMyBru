using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetMyBru.GetMyBru.GUI;
using System.IO;
using GetMyBru.GetMyBru.Core;
using System.Text.RegularExpressions;
using GetMyBru.GetMyBru.Core.Installer;

namespace GetMyBru.GetMyBru.GUI
{
    public partial class FmSelectSystem : MaterialForm
    {
        public static bool SafeExit = true;
        private Form FmWii = new FmWiiMain();
        private Form FmWiiU = new FmWiiUMain();
        private Form FmSwitch = new FmSwitchMain();
        private bool SettingsActive = false;
        private string cd = Environment.CurrentDirectory;
        public static string NotifTitle;
        public static string NotifText;
        public static int NotifTime = 40000;
        public static bool ShowToast;

        public FmSelectSystem()
        {
            Program.EnableVisualsDefault();
            InitializeComponent();
            CheckFirstTime();
            BruParser.PrepareJSON();
        }

        private void CheckFirstTime()
        {
            if (Properties.Settings.Default.FirstTime == true)
            {
                MessageBox.Show("This is the first time you have used this program. " + Environment.NewLine + "We'll need you to change some settings to your liking before we go on.", "Wait a min~", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SettingsActive = true;
                LblSettings.Enabled = false;
            }
        }

        private void FmSelectSystem_Load(object sender, EventArgs e)
        {
            LblVersion.Text = "Version: " + Application.ProductVersion;
            CacheCheck.PerformCheck();
            this.Refresh();
            return;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

/*      private void openSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
         SafeExit = false;
            if (SafeExit == false)
            {
                this.Hide();
                Form FmMain = new FmSelectSystem();
                FmMain.Show();
                return;
            }
            else
            {
                this.Hide();
                FmWii.Close();
                FmWiiU.Close();
                FmSwitch.Close();
                Form FmMain = new FmSelectSystem();
                FmMain.Show();
                return;
            }
        }
*/

        private void LblOk_Click(object sender, EventArgs e)
        {
            if (SettingsActive == true)
            {
                SaveSettings();
                SettingsActive = false;
                return;
            }
            else if (SettingsActive == false)
            {
                SafeExit = true;
                if (RdSwitch.Checked == true)
                {
                    IServiceInstall.ISystem = "switch";
                    FmSwitch.Show();
                    this.Hide();
                    return;
                }
                else if (RdWii.Checked == true)
                {
                    IServiceInstall.ISystem = "wii";
                    FmWii.Show();
                    this.Hide();
                    return;
                }
                else if (RdWiiU.Checked == true)
                {
                    IServiceInstall.ISystem = "wiiu";
                    FmWiiU.Show();
                    this.Hide();
                    return;
                }
            }
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblSettings_Click(object sender, EventArgs e)
        {
            if (SettingsActive == false)
            {
                SettingsActive = true;
                TxtDrive.Clear();
                LoadSettings();
            }
            else if (SettingsActive == true)
            {
                SettingsActive = false;
            }
        }
        private void TmrCheckVal_Tick(object sender, EventArgs e)
        {
            SetLocationButtons();
            if (ShowToast == true)
            {
                NtfMain.BalloonTipTitle = NotifTitle;
                NtfMain.BalloonTipText = NotifText;
                NtfMain.ShowBalloonTip(NotifTime);
                ShowToast = false;
                return;
            }

            if (Properties.Settings.Default.Notif == true)
            {
                if (IServiceInstall.Installed == true)
                {
                    NotifTitle = "GetMyBru";
                    NotifText = "Package: " + FmSwitchMain.AppToInstall + " was installed.";
                    NotifTime = 40000;
                    ShowToast = true;
                    IServiceInstall.Installed = false;
                    return;
                }
            }
        }

        private void SetLocationButtons()
        {
            if (SettingsActive == false)
            {
                LblOk.Text = "Ok";
                LblSettings.Text = "Settings";
                LblOk.Location = new Point(626, 25);
                PcxButtonA.Location = new Point(610, 26);
                LblSettings.Location = new Point(539, 25);
                PcxButtonB.Location = new Point(523, 26);
                LblExit.Location = new Point(478, 25);
                PcxButtonX.Location = new Point(459, 26);
                PnlSettings.Visible = false;

                LoadSettings();
                return;
            }
            if (SettingsActive == true)
            {
                LblOk.Text = "Save";
                LblSettings.Text = "Close Settings";
                LblOk.Location = new Point(626, 25);
                PcxButtonA.Location = new Point(610, 26);
                LblSettings.Location = new Point(497, 25);
                PcxButtonB.Location = new Point(481, 26);
                LblExit.Location = new Point(436, 25);
                PcxButtonX.Location = new Point(417, 26);
                PnlSettings.Visible = true;
                return;
            }
        }

        private void SaveSettings()
        {
            LblSettings.Enabled = true;
            if (ChckAutoUpdate.Checked == true)
            {
                Properties.Settings.Default.AutoUpdate = true;
            }
            else if (ChckAutoUpdate.Checked == false)
            {
                Properties.Settings.Default.AutoUpdate = false;
            }
            if (ChckClean.Checked == true)
            {
                Properties.Settings.Default.Clean = true;
            }
            else if (ChckClean.Checked == false)
            {
                Properties.Settings.Default.Clean = false;
            }
            if (ChckNotif.Checked == true)
            {
                Properties.Settings.Default.Notif = true;
            }
            else if (ChckNotif.Checked == false)
            {
                Properties.Settings.Default.Notif = false;
            }
            if (RdCanary.Checked == true)
            {
                Properties.Settings.Default.Branch = "Canary";
            }
            else if (RdStable.Checked == true)
            {
                Properties.Settings.Default.Branch = "Stable";
            }

            if (Properties.Settings.Default.FirstTime == true)
            {
                Properties.Settings.Default.FirstTime = false;
            }

            Properties.Settings.Default.Save();
            //Write values to JSON
            
            if (String.IsNullOrEmpty(TxtDrive.Text.ToString()) == false && Properties.Settings.Default.FirstTime == true || TxtDrive.Text == String.Empty)
            {
                MessageBox.Show("The Drive text field cannot be left empty!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDrive.Focus();
                SettingsActive = true;
                return;
            }
            if (TxtDrive.Text.Contains(":") || TxtDrive.Text.Contains("\\") || TxtDrive.Text.Contains("/") || TxtDrive.Text.Contains(","))
            {
                MessageBox.Show("The Drive text field contains invalid character/s. Please only input the drive letter!", "Error: Invalid character/s", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDrive.Focus();
                SettingsActive = true;
                NotifTitle = "GetMyBru";
                NotifText = "Failed to save the settings to the Config";
                NotifTime = 40000;
                ShowToast = true;
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(TxtDrive.Text.ToString()))
                {
                    MessageBox.Show("The Drive text field is empty!", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtDrive.Focus();
                    SettingsActive = true;
                    return;
                }
                else
                {
                    Properties.Settings.Default.Drive = TxtDrive.Text;
                    Properties.Settings.Default.Save();
                }
            }

            NotifTitle = "GetMyBru";
            NotifText = "Saved the settings to the Config";
            NotifTime = 40000;
            ShowToast = true;
        }

        private void LoadSettings()
        {
            //Load settings by parsing from JSON, and then storing them into the Applications settings.

            //Load settings from the Applications config
            TxtDrive.Text = Properties.Settings.Default.Drive;
            if (Properties.Settings.Default.Branch == "Stable")
            {
                RdStable.Checked = true;
            }
            else if (Properties.Settings.Default.Branch == "Canary")
            {
                RdCanary.Checked = true;
            }
            if (Properties.Settings.Default.AutoUpdate == true)
            {
                ChckAutoUpdate.Checked = true;
            }
            else if (Properties.Settings.Default.AutoUpdate == true)
            {
                ChckAutoUpdate.Checked = false;
            }
            if (Properties.Settings.Default.Clean == true)
            {
                ChckClean.Checked = true;
            }
            else if (Properties.Settings.Default.Clean == false)
            {
                ChckClean.Checked = false;
            }
            if (Properties.Settings.Default.Notif == true)
            {
                ChckNotif.Checked = true;
            }
            else if (Properties.Settings.Default.Notif == false)
            {
                ChckNotif.Checked = false;
            }
            return;
        }
    }
}
