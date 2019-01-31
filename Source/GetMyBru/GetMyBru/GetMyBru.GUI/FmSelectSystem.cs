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

        public FmSelectSystem()
        {
            Program.EnableVisualsDefault();
            InitializeComponent();
        }

        private void LblOk_Click(object sender, EventArgs e)
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

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}