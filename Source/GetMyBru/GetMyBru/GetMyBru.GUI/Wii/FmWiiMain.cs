﻿using MaterialSkin.Controls;
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
    public partial class FmWiiMain : MaterialForm
    {
        public FmWiiMain()
        {
            InitializeComponent();
            Program.EnableVisualsWii();
        }

        private void FmWiiMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FmWiiMain_Load(object sender, EventArgs e)
        {
            LblVersion.Text = "Version: " + Application.ProductVersion;
            return;
        }
    }
}