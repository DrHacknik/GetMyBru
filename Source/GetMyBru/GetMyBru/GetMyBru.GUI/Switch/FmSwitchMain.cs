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
        public FmSwitchMain()
        {
            InitializeComponent();
            Program.EnableVisualsSwitch();
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
            return;
        }
    }
}