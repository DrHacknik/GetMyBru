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
        public FmSelectSystem()
        {
            Program.EnableVisualsDefault();
            InitializeComponent();
        }

        private void LblOk_Click(object sender, EventArgs e)
        {
            if (RdSwitch.Checked == true)
            {
                Form FmSwitch = new FmSwitchMain();
                FmSwitch.Show();
                this.Hide();
                return;
            }
            else if (RdWii.Checked == true)
            {
                Form FmWii = new FmWiiMain();
                FmWii.Show();
                this.Hide();
                return;
            }
            else if (RdWiiU.Checked == true)
            {
                Form FmWiiU = new FmWiiUMain();
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
    }
}