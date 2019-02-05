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

namespace GetMyBru.GetMyBru.GUI
{
    public partial class FmSelectSystem : MaterialForm
    {
        public static bool SafeExit = true;
        private Form FmWii = new FmWiiMain();
        private Form FmWiiU = new FmWiiUMain();
        private Form FmSwitch = new FmSwitchMain();
        private bool SettingsActive = false;

        public FmSelectSystem()
        {
            Program.EnableVisualsDefault();
            InitializeComponent();
        }

        private void FmSelectSystem_Load(object sender, EventArgs e)
        {
            LblVersion.Text = "Version: " + Application.ProductVersion;
            this.Refresh();
            return;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openSelectorToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void LblOk_Click(object sender, EventArgs e)
        {
            if (SettingsActive == true)
            {
                //SaveSettings();
                SettingsActive = false;
                return;
            }
            else if (SettingsActive == false)
            {
                SafeExit = true;
                if (RdSwitch.Checked == true)
                {
                    FmSwitch.Show();
                    this.Hide();
                    return;
                }
                else if (RdWii.Checked == true)
                {
                    FmWii.Show();
                    this.Hide();
                    return;
                }
                else if (RdWiiU.Checked == true)
                {
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
            //MessageBox.Show("Please do keep in mind that this feature is not implemented yet.", "Do note:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //return;

            if (SettingsActive == false)
            {
                SettingsActive = true;
            }
            else if (SettingsActive == true)
            {
                SettingsActive = false;
            }
        }

        private void TmrCheckVal_Tick(object sender, EventArgs e)
        {
            SetLocationButtons();
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
            else if (ChckAutoUpdate.Checked == false)
            {
                Properties.Settings.Default.Clean = false;
            }

            if (RdCanary.Checked == true)
            {
                Properties.Settings.Default.Branch = "Canary";
            }
            else if (RdStable.Checked == true)
            {
                Properties.Settings.Default.Branch = "Stable";
            }

            //Write values to JSON
            return;
        }

        public static void LoadSettings()
        {
            //Load settings by parsing from JSON, and then storing them into the Applications settings.
        }
    }
}