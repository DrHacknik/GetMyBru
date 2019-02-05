using GetMyBru.GetMyBru.Core.Net.Parser;
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

namespace GetMyBru.GetMyBru.GUI
{
    public partial class FmSwitchMain : MaterialForm
    {
        private bool AppInView = false;

        public FmSwitchMain()
        {
            InitializeComponent();
            Program.EnableVisualsDefault();
        }

        private void FmSwitchMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FmSelectSystem.SafeExit == false)
            {
                this.Close();
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        private void FmSwitchMain_Load(object sender, EventArgs e)
        {
            LblVersion.Text = "Version: " + Application.ProductVersion;

            BruParser.ParseJSONSwitch();
            //MessageBox.Show("Packages RAW Data returned:" + Environment.NewLine + BruParser.PackagesRawList, "Packages:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TmrCheckVal_Tick(object sender, EventArgs e)
        {
            if (AppInView == true)
            {
                ShowAppInfo();
                return;
            }
            else if (AppInView == false)
            {
                HideAppInfo();
                return;
            }
        }

        private void ShowAppInfo()
        {
            PnlInfo.Visible = true;
            return;
        }

        private void HideAppInfo()
        {
            PnlInfo.Visible = false;
            return;
        }

        private void LblView_Click(object sender, EventArgs e)
        {
            if (AppInView == false)
            {
                LblView.Text = "Close Info";
                AppInView = true;
            }
            else if (AppInView == true)
            {
                LblView.Text = "View App";
                AppInView = false;
            }
        }
    }
}