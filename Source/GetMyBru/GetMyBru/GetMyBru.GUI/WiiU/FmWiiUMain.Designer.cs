namespace GetMyBru.GetMyBru.GUI
{
    partial class FmWiiUMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmWiiUMain));
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.PnlSplitter = new System.Windows.Forms.Panel();
            this.PcxWiiULogo = new System.Windows.Forms.PictureBox();
            this.PcxExit = new System.Windows.Forms.PictureBox();
            this.LblExit = new MaterialSkin.Controls.MaterialLabel();
            this.PcxSettings = new System.Windows.Forms.PictureBox();
            this.LblSettings = new MaterialSkin.Controls.MaterialLabel();
            this.PcxALogo = new System.Windows.Forms.PictureBox();
            this.LblInstall = new MaterialSkin.Controls.MaterialLabel();
            this.LblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.TbPage = new MaterialSkin.Controls.MaterialTabControl();
            this.TbHome = new System.Windows.Forms.TabPage();
            this.TbLoad = new System.Windows.Forms.TabPage();
            this.TbGame = new System.Windows.Forms.TabPage();
            this.TbEmu = new System.Windows.Forms.TabPage();
            this.TbTools = new System.Windows.Forms.TabPage();
            this.TbConc = new System.Windows.Forms.TabPage();
            this.TbAdv = new System.Windows.Forms.TabPage();
            this.TbSel = new MaterialSkin.Controls.MaterialTabSelector();
            this.PnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxWiiULogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxALogo)).BeginInit();
            this.TbPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.LblVersion);
            this.PnlBottom.Controls.Add(this.PcxExit);
            this.PnlBottom.Controls.Add(this.LblExit);
            this.PnlBottom.Controls.Add(this.PcxSettings);
            this.PnlBottom.Controls.Add(this.LblSettings);
            this.PnlBottom.Controls.Add(this.PcxALogo);
            this.PnlBottom.Controls.Add(this.LblInstall);
            this.PnlBottom.Controls.Add(this.PnlSplitter);
            this.PnlBottom.Controls.Add(this.PcxWiiULogo);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 683);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(1011, 63);
            this.PnlBottom.TabIndex = 4;
            // 
            // PnlSplitter
            // 
            this.PnlSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSplitter.BackColor = System.Drawing.Color.White;
            this.PnlSplitter.Location = new System.Drawing.Point(12, 8);
            this.PnlSplitter.Name = "PnlSplitter";
            this.PnlSplitter.Size = new System.Drawing.Size(984, 2);
            this.PnlSplitter.TabIndex = 4;
            // 
            // PcxWiiULogo
            // 
            this.PcxWiiULogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxWiiULogo.BackColor = System.Drawing.Color.Transparent;
            this.PcxWiiULogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxWiiULogo.BackgroundImage")));
            this.PcxWiiULogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxWiiULogo.Location = new System.Drawing.Point(22, 19);
            this.PcxWiiULogo.Name = "PcxWiiULogo";
            this.PcxWiiULogo.Size = new System.Drawing.Size(36, 32);
            this.PcxWiiULogo.TabIndex = 3;
            this.PcxWiiULogo.TabStop = false;
            // 
            // PcxExit
            // 
            this.PcxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxExit.BackColor = System.Drawing.Color.Transparent;
            this.PcxExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxExit.BackgroundImage")));
            this.PcxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxExit.Location = new System.Drawing.Point(777, 27);
            this.PcxExit.Name = "PcxExit";
            this.PcxExit.Size = new System.Drawing.Size(16, 16);
            this.PcxExit.TabIndex = 15;
            this.PcxExit.TabStop = false;
            // 
            // LblExit
            // 
            this.LblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblExit.AutoSize = true;
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Depth = 0;
            this.LblExit.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblExit.Location = new System.Drawing.Point(793, 25);
            this.LblExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(34, 19);
            this.LblExit.TabIndex = 16;
            this.LblExit.Text = "Exit";
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // PcxSettings
            // 
            this.PcxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxSettings.BackColor = System.Drawing.Color.Transparent;
            this.PcxSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxSettings.BackgroundImage")));
            this.PcxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxSettings.Location = new System.Drawing.Point(838, 27);
            this.PcxSettings.Name = "PcxSettings";
            this.PcxSettings.Size = new System.Drawing.Size(16, 16);
            this.PcxSettings.TabIndex = 13;
            this.PcxSettings.TabStop = false;
            // 
            // LblSettings
            // 
            this.LblSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSettings.AutoSize = true;
            this.LblSettings.BackColor = System.Drawing.Color.Transparent;
            this.LblSettings.Depth = 0;
            this.LblSettings.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSettings.Location = new System.Drawing.Point(854, 25);
            this.LblSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSettings.Name = "LblSettings";
            this.LblSettings.Size = new System.Drawing.Size(64, 19);
            this.LblSettings.TabIndex = 14;
            this.LblSettings.Text = "Settings";
            // 
            // PcxALogo
            // 
            this.PcxALogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxALogo.BackColor = System.Drawing.Color.Transparent;
            this.PcxALogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxALogo.BackgroundImage")));
            this.PcxALogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxALogo.Location = new System.Drawing.Point(933, 27);
            this.PcxALogo.Name = "PcxALogo";
            this.PcxALogo.Size = new System.Drawing.Size(16, 16);
            this.PcxALogo.TabIndex = 11;
            this.PcxALogo.TabStop = false;
            // 
            // LblInstall
            // 
            this.LblInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInstall.AutoSize = true;
            this.LblInstall.BackColor = System.Drawing.Color.Transparent;
            this.LblInstall.Depth = 0;
            this.LblInstall.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblInstall.Location = new System.Drawing.Point(949, 25);
            this.LblInstall.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblInstall.Name = "LblInstall";
            this.LblInstall.Size = new System.Drawing.Size(50, 19);
            this.LblInstall.TabIndex = 12;
            this.LblInstall.Text = "Install";
            // 
            // LblVersion
            // 
            this.LblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblVersion.AutoSize = true;
            this.LblVersion.BackColor = System.Drawing.Color.Transparent;
            this.LblVersion.Depth = 0;
            this.LblVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblVersion.Location = new System.Drawing.Point(64, 25);
            this.LblVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(59, 19);
            this.LblVersion.TabIndex = 17;
            this.LblVersion.Text = "%VER%";
            // 
            // TbPage
            // 
            this.TbPage.Controls.Add(this.TbHome);
            this.TbPage.Controls.Add(this.TbLoad);
            this.TbPage.Controls.Add(this.TbGame);
            this.TbPage.Controls.Add(this.TbEmu);
            this.TbPage.Controls.Add(this.TbTools);
            this.TbPage.Controls.Add(this.TbConc);
            this.TbPage.Controls.Add(this.TbAdv);
            this.TbPage.Depth = 0;
            this.TbPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbPage.Location = new System.Drawing.Point(0, 103);
            this.TbPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbPage.Name = "TbPage";
            this.TbPage.SelectedIndex = 0;
            this.TbPage.Size = new System.Drawing.Size(1011, 580);
            this.TbPage.TabIndex = 5;
            // 
            // TbHome
            // 
            this.TbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TbHome.Location = new System.Drawing.Point(4, 22);
            this.TbHome.Name = "TbHome";
            this.TbHome.Size = new System.Drawing.Size(1003, 554);
            this.TbHome.TabIndex = 0;
            this.TbHome.Text = "Home";
            // 
            // TbLoad
            // 
            this.TbLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TbLoad.Location = new System.Drawing.Point(4, 22);
            this.TbLoad.Name = "TbLoad";
            this.TbLoad.Size = new System.Drawing.Size(1003, 554);
            this.TbLoad.TabIndex = 1;
            this.TbLoad.Text = "Loaders";
            // 
            // TbGame
            // 
            this.TbGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TbGame.Location = new System.Drawing.Point(4, 22);
            this.TbGame.Name = "TbGame";
            this.TbGame.Size = new System.Drawing.Size(1003, 554);
            this.TbGame.TabIndex = 2;
            this.TbGame.Text = "Games";
            // 
            // TbEmu
            // 
            this.TbEmu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TbEmu.Location = new System.Drawing.Point(4, 22);
            this.TbEmu.Name = "TbEmu";
            this.TbEmu.Size = new System.Drawing.Size(1003, 554);
            this.TbEmu.TabIndex = 3;
            this.TbEmu.Text = "Emulators";
            // 
            // TbTools
            // 
            this.TbTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TbTools.Location = new System.Drawing.Point(4, 22);
            this.TbTools.Name = "TbTools";
            this.TbTools.Size = new System.Drawing.Size(1003, 554);
            this.TbTools.TabIndex = 4;
            this.TbTools.Text = "Tools";
            // 
            // TbConc
            // 
            this.TbConc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TbConc.Location = new System.Drawing.Point(4, 22);
            this.TbConc.Name = "TbConc";
            this.TbConc.Size = new System.Drawing.Size(1003, 554);
            this.TbConc.TabIndex = 5;
            this.TbConc.Text = "Concepts";
            // 
            // TbAdv
            // 
            this.TbAdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TbAdv.Location = new System.Drawing.Point(4, 22);
            this.TbAdv.Name = "TbAdv";
            this.TbAdv.Size = new System.Drawing.Size(1003, 554);
            this.TbAdv.TabIndex = 6;
            this.TbAdv.Text = "Advanced";
            // 
            // TbSel
            // 
            this.TbSel.BaseTabControl = this.TbPage;
            this.TbSel.Depth = 0;
            this.TbSel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbSel.Location = new System.Drawing.Point(0, 62);
            this.TbSel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbSel.Name = "TbSel";
            this.TbSel.Size = new System.Drawing.Size(1011, 41);
            this.TbSel.TabIndex = 6;
            // 
            // FmWiiUMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1011, 746);
            this.Controls.Add(this.TbSel);
            this.Controls.Add(this.TbPage);
            this.Controls.Add(this.PnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmWiiUMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmWiiUMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmWiiUMain_FormClosing);
            this.Load += new System.EventHandler(this.FmWiiUMain_Load);
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxWiiULogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxALogo)).EndInit();
            this.TbPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlSplitter;
        private System.Windows.Forms.PictureBox PcxWiiULogo;
        private System.Windows.Forms.PictureBox PcxExit;
        private MaterialSkin.Controls.MaterialLabel LblExit;
        private System.Windows.Forms.PictureBox PcxSettings;
        private MaterialSkin.Controls.MaterialLabel LblSettings;
        private System.Windows.Forms.PictureBox PcxALogo;
        private MaterialSkin.Controls.MaterialLabel LblInstall;
        private MaterialSkin.Controls.MaterialLabel LblVersion;
        private MaterialSkin.Controls.MaterialTabControl TbPage;
        private System.Windows.Forms.TabPage TbHome;
        private System.Windows.Forms.TabPage TbLoad;
        private System.Windows.Forms.TabPage TbGame;
        private System.Windows.Forms.TabPage TbEmu;
        private System.Windows.Forms.TabPage TbTools;
        private System.Windows.Forms.TabPage TbConc;
        private System.Windows.Forms.TabPage TbAdv;
        private MaterialSkin.Controls.MaterialTabSelector TbSel;
    }
}