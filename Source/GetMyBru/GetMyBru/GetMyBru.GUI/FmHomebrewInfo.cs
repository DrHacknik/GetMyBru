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
    public partial class FmHomebrewInfo : MaterialForm
    {
        public static string ConAppName;
        public static string ConAppDescShort;
        public static string ConAppDescFull;
        public static string ConAppCreator;
        public static string ConAppDateLast;
        public static string ConAppGitUrl;
        public static string ConAppVersion;
        public static string ConAppImageUrl;
        public static bool ConAppInstalled;
        public static bool ConAppOutdated;
        public static bool ConAppDisplayed = false;

        public FmHomebrewInfo()
        {
            InitializeComponent();
            Program.EnableVisualsDefault();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowInfo()
        {
            LblInfo.Visible = true;
            LblInfoBody.Visible = true;
            LblInfoHeader.Visible = true;
            BtnClose.Visible = true;
            BtnInstall.Visible = true;
            PcxInfoIcon.Visible = true;
            return;
        }

        private void HideInfo()
        {
            LblInfo.Visible = false;
            LblInfoBody.Visible = false;
            LblInfoHeader.Visible = false;
            BtnClose.Visible = false;
            BtnInstall.Visible = false;
            PcxInfoIcon.Visible = false;
            return;
        }

        private void FmHomebrewInfo_Load(object sender, EventArgs e)
        {
            LblInfoHeader.Text = ConAppName;
            LblInfo.Text = "App Information:" + Environment.NewLine + Environment.NewLine + "Version: " + ConAppVersion + Environment.NewLine + "Creator: " + ConAppCreator + Environment.NewLine + "Last Updated: " + ConAppDateLast + Environment.NewLine + "Git Url: " + ConAppGitUrl;
            LblInfoBody.Text = ConAppDescFull;

            if (ConAppInstalled == true)
            {
                if (ConAppOutdated == true)
                {
                    BtnInstall.Text = "Update";
                }
                else
                {
                    BtnInstall.Text = "Remove";
                }
            }
        }
    }
}