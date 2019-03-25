namespace GetMyBru.GetMyBru.GUI
{
    partial class FmSelectSystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSelectSystem));
            this.LblHeader = new MaterialSkin.Controls.MaterialLabel();
            this.LblBody = new MaterialSkin.Controls.MaterialLabel();
            this.RdSwitch = new MaterialSkin.Controls.MaterialRadioButton();
            this.RdWiiU = new MaterialSkin.Controls.MaterialRadioButton();
            this.NtfMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.MtxMain = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.openSelectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.PcxButtonX = new System.Windows.Forms.PictureBox();
            this.PcxButtonB = new System.Windows.Forms.PictureBox();
            this.PcxButtonA = new System.Windows.Forms.PictureBox();
            this.LblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.PcxExit = new System.Windows.Forms.PictureBox();
            this.LblExit = new MaterialSkin.Controls.MaterialLabel();
            this.PcxSettings = new System.Windows.Forms.PictureBox();
            this.LblSettings = new MaterialSkin.Controls.MaterialLabel();
            this.PcxALogo = new System.Windows.Forms.PictureBox();
            this.LblOk = new MaterialSkin.Controls.MaterialLabel();
            this.PnlSplitterFooter = new System.Windows.Forms.Panel();
            this.PcxSwitchLogo = new System.Windows.Forms.PictureBox();
            this.RdWii = new MaterialSkin.Controls.MaterialRadioButton();
            this.PnlSettings = new System.Windows.Forms.Panel();
            this.TxtDrive = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ChckNotif = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblBranch = new MaterialSkin.Controls.MaterialLabel();
            this.RdCanary = new MaterialSkin.Controls.MaterialRadioButton();
            this.RdStable = new MaterialSkin.Controls.MaterialRadioButton();
            this.PnlSplitterMid = new System.Windows.Forms.Panel();
            this.ChckClean = new MaterialSkin.Controls.MaterialCheckBox();
            this.PnlSplitterHeader = new System.Windows.Forms.Panel();
            this.PcxSettingsIcon = new System.Windows.Forms.PictureBox();
            this.LblSettingsHeader = new MaterialSkin.Controls.MaterialLabel();
            this.ChckAutoUpdate = new MaterialSkin.Controls.MaterialCheckBox();
            this.TmrCheckVal = new System.Windows.Forms.Timer(this.components);
            this.PcxWii = new System.Windows.Forms.PictureBox();
            this.PcxWiiU = new System.Windows.Forms.PictureBox();
            this.PcxSwitch = new System.Windows.Forms.PictureBox();
            this.MtxMain.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxButtonX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxButtonB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxButtonA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxALogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSwitchLogo)).BeginInit();
            this.PnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSettingsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxWii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxWiiU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.BackColor = System.Drawing.Color.Transparent;
            this.LblHeader.Depth = 0;
            this.LblHeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblHeader.Location = new System.Drawing.Point(32, 89);
            this.LblHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(630, 41);
            this.LblHeader.TabIndex = 4;
            this.LblHeader.Text = "Welcome, please choose a System";
            // 
            // LblBody
            // 
            this.LblBody.BackColor = System.Drawing.Color.Transparent;
            this.LblBody.Depth = 0;
            this.LblBody.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblBody.Location = new System.Drawing.Point(33, 130);
            this.LblBody.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBody.Name = "LblBody";
            this.LblBody.Size = new System.Drawing.Size(630, 60);
            this.LblBody.TabIndex = 5;
            this.LblBody.Text = "You may choose from the Nintendo Wii, Wii U and Switch systems. \r\nEach have their" +
    " own methods of obtaining homebrew and installing it \r\nonto an SD card or USB De" +
    "vice. ";
            // 
            // RdSwitch
            // 
            this.RdSwitch.AutoSize = true;
            this.RdSwitch.BackColor = System.Drawing.Color.Transparent;
            this.RdSwitch.Checked = true;
            this.RdSwitch.Depth = 0;
            this.RdSwitch.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdSwitch.Location = new System.Drawing.Point(85, 344);
            this.RdSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.RdSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdSwitch.Name = "RdSwitch";
            this.RdSwitch.Ripple = true;
            this.RdSwitch.Size = new System.Drawing.Size(70, 30);
            this.RdSwitch.TabIndex = 1;
            this.RdSwitch.TabStop = true;
            this.RdSwitch.Text = "Switch";
            this.RdSwitch.UseVisualStyleBackColor = false;
            // 
            // RdWiiU
            // 
            this.RdWiiU.AutoSize = true;
            this.RdWiiU.BackColor = System.Drawing.Color.Transparent;
            this.RdWiiU.Depth = 0;
            this.RdWiiU.Enabled = false;
            this.RdWiiU.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdWiiU.Location = new System.Drawing.Point(304, 344);
            this.RdWiiU.Margin = new System.Windows.Forms.Padding(0);
            this.RdWiiU.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdWiiU.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdWiiU.Name = "RdWiiU";
            this.RdWiiU.Ripple = true;
            this.RdWiiU.Size = new System.Drawing.Size(60, 30);
            this.RdWiiU.TabIndex = 2;
            this.RdWiiU.Text = "Wii U ";
            this.RdWiiU.UseVisualStyleBackColor = false;
            // 
            // NtfMain
            // 
            this.NtfMain.ContextMenuStrip = this.MtxMain;
            this.NtfMain.Icon = ((System.Drawing.Icon)(resources.GetObject("NtfMain.Icon")));
            this.NtfMain.Text = "Get My Bru Panel";
            this.NtfMain.Visible = true;
            // 
            // MtxMain
            // 
            this.MtxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MtxMain.Depth = 0;
            this.MtxMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSelectorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MtxMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtxMain.Name = "MtxMain";
            this.MtxMain.Size = new System.Drawing.Size(94, 48);
            // 
            // openSelectorToolStripMenuItem
            // 
            this.openSelectorToolStripMenuItem.Name = "openSelectorToolStripMenuItem";
            this.openSelectorToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.PcxButtonX);
            this.PnlBottom.Controls.Add(this.PcxButtonB);
            this.PnlBottom.Controls.Add(this.PcxButtonA);
            this.PnlBottom.Controls.Add(this.LblVersion);
            this.PnlBottom.Controls.Add(this.PcxExit);
            this.PnlBottom.Controls.Add(this.LblExit);
            this.PnlBottom.Controls.Add(this.PcxSettings);
            this.PnlBottom.Controls.Add(this.LblSettings);
            this.PnlBottom.Controls.Add(this.PcxALogo);
            this.PnlBottom.Controls.Add(this.LblOk);
            this.PnlBottom.Controls.Add(this.PnlSplitterFooter);
            this.PnlBottom.Controls.Add(this.PcxSwitchLogo);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 418);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(674, 63);
            this.PnlBottom.TabIndex = 7;
            // 
            // PcxButtonX
            // 
            this.PcxButtonX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxButtonX.BackColor = System.Drawing.Color.Transparent;
            this.PcxButtonX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxButtonX.BackgroundImage")));
            this.PcxButtonX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxButtonX.Location = new System.Drawing.Point(459, 26);
            this.PcxButtonX.Name = "PcxButtonX";
            this.PcxButtonX.Size = new System.Drawing.Size(16, 16);
            this.PcxButtonX.TabIndex = 20;
            this.PcxButtonX.TabStop = false;
            // 
            // PcxButtonB
            // 
            this.PcxButtonB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxButtonB.BackColor = System.Drawing.Color.Transparent;
            this.PcxButtonB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxButtonB.BackgroundImage")));
            this.PcxButtonB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxButtonB.Location = new System.Drawing.Point(523, 26);
            this.PcxButtonB.Name = "PcxButtonB";
            this.PcxButtonB.Size = new System.Drawing.Size(16, 16);
            this.PcxButtonB.TabIndex = 19;
            this.PcxButtonB.TabStop = false;
            // 
            // PcxButtonA
            // 
            this.PcxButtonA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxButtonA.BackColor = System.Drawing.Color.Transparent;
            this.PcxButtonA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxButtonA.BackgroundImage")));
            this.PcxButtonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxButtonA.Location = new System.Drawing.Point(610, 26);
            this.PcxButtonA.Name = "PcxButtonA";
            this.PcxButtonA.Size = new System.Drawing.Size(16, 16);
            this.PcxButtonA.TabIndex = 18;
            this.PcxButtonA.TabStop = false;
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
            this.LblExit.Location = new System.Drawing.Point(478, 25);
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
            this.LblSettings.Location = new System.Drawing.Point(539, 25);
            this.LblSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSettings.Name = "LblSettings";
            this.LblSettings.Size = new System.Drawing.Size(64, 19);
            this.LblSettings.TabIndex = 14;
            this.LblSettings.Text = "Settings";
            this.LblSettings.Click += new System.EventHandler(this.LblSettings_Click);
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
            // LblOk
            // 
            this.LblOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblOk.AutoSize = true;
            this.LblOk.BackColor = System.Drawing.Color.Transparent;
            this.LblOk.Depth = 0;
            this.LblOk.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblOk.Location = new System.Drawing.Point(626, 25);
            this.LblOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblOk.Name = "LblOk";
            this.LblOk.Size = new System.Drawing.Size(27, 19);
            this.LblOk.TabIndex = 12;
            this.LblOk.Text = "Ok";
            this.LblOk.Click += new System.EventHandler(this.LblOk_Click);
            // 
            // PnlSplitterFooter
            // 
            this.PnlSplitterFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSplitterFooter.BackColor = System.Drawing.Color.White;
            this.PnlSplitterFooter.Location = new System.Drawing.Point(12, 8);
            this.PnlSplitterFooter.Name = "PnlSplitterFooter";
            this.PnlSplitterFooter.Size = new System.Drawing.Size(647, 2);
            this.PnlSplitterFooter.TabIndex = 4;
            // 
            // PcxSwitchLogo
            // 
            this.PcxSwitchLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxSwitchLogo.BackColor = System.Drawing.Color.Transparent;
            this.PcxSwitchLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxSwitchLogo.BackgroundImage")));
            this.PcxSwitchLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxSwitchLogo.Location = new System.Drawing.Point(22, 19);
            this.PcxSwitchLogo.Name = "PcxSwitchLogo";
            this.PcxSwitchLogo.Size = new System.Drawing.Size(36, 32);
            this.PcxSwitchLogo.TabIndex = 3;
            this.PcxSwitchLogo.TabStop = false;
            // 
            // RdWii
            // 
            this.RdWii.AutoSize = true;
            this.RdWii.BackColor = System.Drawing.Color.Transparent;
            this.RdWii.Depth = 0;
            this.RdWii.Enabled = false;
            this.RdWii.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdWii.Location = new System.Drawing.Point(525, 344);
            this.RdWii.Margin = new System.Windows.Forms.Padding(0);
            this.RdWii.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdWii.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdWii.Name = "RdWii";
            this.RdWii.Ripple = true;
            this.RdWii.Size = new System.Drawing.Size(48, 30);
            this.RdWii.TabIndex = 3;
            this.RdWii.Text = "Wii";
            this.RdWii.UseVisualStyleBackColor = false;
            // 
            // PnlSettings
            // 
            this.PnlSettings.Controls.Add(this.TxtDrive);
            this.PnlSettings.Controls.Add(this.ChckNotif);
            this.PnlSettings.Controls.Add(this.panel1);
            this.PnlSettings.Controls.Add(this.LblBranch);
            this.PnlSettings.Controls.Add(this.RdCanary);
            this.PnlSettings.Controls.Add(this.RdStable);
            this.PnlSettings.Controls.Add(this.PnlSplitterMid);
            this.PnlSettings.Controls.Add(this.ChckClean);
            this.PnlSettings.Controls.Add(this.PnlSplitterHeader);
            this.PnlSettings.Controls.Add(this.PcxSettingsIcon);
            this.PnlSettings.Controls.Add(this.LblSettingsHeader);
            this.PnlSettings.Controls.Add(this.ChckAutoUpdate);
            this.PnlSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlSettings.Location = new System.Drawing.Point(0, 64);
            this.PnlSettings.Name = "PnlSettings";
            this.PnlSettings.Size = new System.Drawing.Size(674, 354);
            this.PnlSettings.TabIndex = 8;
            this.PnlSettings.Visible = false;
            // 
            // TxtDrive
            // 
            this.TxtDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDrive.Depth = 0;
            this.TxtDrive.Hint = "Please enter a drive letter. Ex: D";
            this.TxtDrive.Location = new System.Drawing.Point(413, 304);
            this.TxtDrive.MaxLength = 32767;
            this.TxtDrive.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDrive.Name = "TxtDrive";
            this.TxtDrive.PasswordChar = '\0';
            this.TxtDrive.SelectedText = "";
            this.TxtDrive.SelectionLength = 0;
            this.TxtDrive.SelectionStart = 0;
            this.TxtDrive.Size = new System.Drawing.Size(240, 23);
            this.TxtDrive.TabIndex = 14;
            this.TxtDrive.TabStop = false;
            this.TxtDrive.UseSystemPasswordChar = false;
            // 
            // ChckNotif
            // 
            this.ChckNotif.AutoSize = true;
            this.ChckNotif.BackColor = System.Drawing.Color.Transparent;
            this.ChckNotif.Depth = 0;
            this.ChckNotif.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChckNotif.ForeColor = System.Drawing.Color.White;
            this.ChckNotif.Location = new System.Drawing.Point(37, 301);
            this.ChckNotif.Margin = new System.Windows.Forms.Padding(0);
            this.ChckNotif.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChckNotif.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChckNotif.Name = "ChckNotif";
            this.ChckNotif.Ripple = true;
            this.ChckNotif.Size = new System.Drawing.Size(195, 30);
            this.ChckNotif.TabIndex = 13;
            this.ChckNotif.Text = "Enable Push Notifications?";
            this.ChckNotif.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(22, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 2);
            this.panel1.TabIndex = 12;
            // 
            // LblBranch
            // 
            this.LblBranch.AutoSize = true;
            this.LblBranch.Depth = 0;
            this.LblBranch.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblBranch.Location = new System.Drawing.Point(33, 167);
            this.LblBranch.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBranch.Name = "LblBranch";
            this.LblBranch.Size = new System.Drawing.Size(172, 19);
            this.LblBranch.TabIndex = 11;
            this.LblBranch.Text = "Select an Update Branch";
            // 
            // RdCanary
            // 
            this.RdCanary.AutoSize = true;
            this.RdCanary.Depth = 0;
            this.RdCanary.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdCanary.Location = new System.Drawing.Point(36, 228);
            this.RdCanary.Margin = new System.Windows.Forms.Padding(0);
            this.RdCanary.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdCanary.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdCanary.Name = "RdCanary";
            this.RdCanary.Ripple = true;
            this.RdCanary.Size = new System.Drawing.Size(236, 30);
            this.RdCanary.TabIndex = 4;
            this.RdCanary.Text = "Use the Unstable Branch (Canary)";
            this.RdCanary.UseVisualStyleBackColor = true;
            // 
            // RdStable
            // 
            this.RdStable.AutoSize = true;
            this.RdStable.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdStable.Checked = true;
            this.RdStable.Depth = 0;
            this.RdStable.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdStable.Location = new System.Drawing.Point(36, 198);
            this.RdStable.Margin = new System.Windows.Forms.Padding(0);
            this.RdStable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdStable.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdStable.Name = "RdStable";
            this.RdStable.Ripple = true;
            this.RdStable.Size = new System.Drawing.Size(221, 30);
            this.RdStable.TabIndex = 3;
            this.RdStable.TabStop = true;
            this.RdStable.Text = "Use the Stable Branch (Master)";
            this.RdStable.UseVisualStyleBackColor = true;
            // 
            // PnlSplitterMid
            // 
            this.PnlSplitterMid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSplitterMid.BackColor = System.Drawing.Color.Gray;
            this.PnlSplitterMid.Location = new System.Drawing.Point(22, 157);
            this.PnlSplitterMid.Name = "PnlSplitterMid";
            this.PnlSplitterMid.Size = new System.Drawing.Size(622, 2);
            this.PnlSplitterMid.TabIndex = 9;
            // 
            // ChckClean
            // 
            this.ChckClean.AutoSize = true;
            this.ChckClean.BackColor = System.Drawing.Color.Transparent;
            this.ChckClean.Depth = 0;
            this.ChckClean.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChckClean.ForeColor = System.Drawing.Color.White;
            this.ChckClean.Location = new System.Drawing.Point(36, 109);
            this.ChckClean.Margin = new System.Windows.Forms.Padding(0);
            this.ChckClean.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChckClean.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChckClean.Name = "ChckClean";
            this.ChckClean.Ripple = true;
            this.ChckClean.Size = new System.Drawing.Size(217, 30);
            this.ChckClean.TabIndex = 2;
            this.ChckClean.Text = "Cleanup Cache when all done?";
            this.ChckClean.UseVisualStyleBackColor = false;
            // 
            // PnlSplitterHeader
            // 
            this.PnlSplitterHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSplitterHeader.BackColor = System.Drawing.Color.White;
            this.PnlSplitterHeader.Location = new System.Drawing.Point(12, 61);
            this.PnlSplitterHeader.Name = "PnlSplitterHeader";
            this.PnlSplitterHeader.Size = new System.Drawing.Size(647, 2);
            this.PnlSplitterHeader.TabIndex = 5;
            // 
            // PcxSettingsIcon
            // 
            this.PcxSettingsIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxSettingsIcon.BackColor = System.Drawing.Color.Transparent;
            this.PcxSettingsIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxSettingsIcon.BackgroundImage")));
            this.PcxSettingsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxSettingsIcon.Location = new System.Drawing.Point(22, 14);
            this.PcxSettingsIcon.Name = "PcxSettingsIcon";
            this.PcxSettingsIcon.Size = new System.Drawing.Size(36, 32);
            this.PcxSettingsIcon.TabIndex = 4;
            this.PcxSettingsIcon.TabStop = false;
            // 
            // LblSettingsHeader
            // 
            this.LblSettingsHeader.AutoSize = true;
            this.LblSettingsHeader.Depth = 0;
            this.LblSettingsHeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblSettingsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSettingsHeader.Location = new System.Drawing.Point(64, 21);
            this.LblSettingsHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSettingsHeader.Name = "LblSettingsHeader";
            this.LblSettingsHeader.Size = new System.Drawing.Size(133, 19);
            this.LblSettingsHeader.TabIndex = 1;
            this.LblSettingsHeader.Text = "GetMyBru Settings";
            // 
            // ChckAutoUpdate
            // 
            this.ChckAutoUpdate.AutoSize = true;
            this.ChckAutoUpdate.BackColor = System.Drawing.Color.Transparent;
            this.ChckAutoUpdate.Depth = 0;
            this.ChckAutoUpdate.Enabled = false;
            this.ChckAutoUpdate.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChckAutoUpdate.ForeColor = System.Drawing.Color.White;
            this.ChckAutoUpdate.Location = new System.Drawing.Point(36, 79);
            this.ChckAutoUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.ChckAutoUpdate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChckAutoUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChckAutoUpdate.Name = "ChckAutoUpdate";
            this.ChckAutoUpdate.Ripple = true;
            this.ChckAutoUpdate.Size = new System.Drawing.Size(200, 30);
            this.ChckAutoUpdate.TabIndex = 1;
            this.ChckAutoUpdate.Text = "Enable Automatic Updates?";
            this.ChckAutoUpdate.UseVisualStyleBackColor = false;
            // 
            // TmrCheckVal
            // 
            this.TmrCheckVal.Enabled = true;
            this.TmrCheckVal.Tick += new System.EventHandler(this.TmrCheckVal_Tick);
            // 
            // PcxWii
            // 
            this.PcxWii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PcxWii.BackColor = System.Drawing.Color.Transparent;
            this.PcxWii.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxWii.BackgroundImage")));
            this.PcxWii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxWii.Location = new System.Drawing.Point(480, 210);
            this.PcxWii.Name = "PcxWii";
            this.PcxWii.Size = new System.Drawing.Size(142, 131);
            this.PcxWii.TabIndex = 6;
            this.PcxWii.TabStop = false;
            // 
            // PcxWiiU
            // 
            this.PcxWiiU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PcxWiiU.BackColor = System.Drawing.Color.Transparent;
            this.PcxWiiU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxWiiU.BackgroundImage")));
            this.PcxWiiU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxWiiU.Location = new System.Drawing.Point(267, 210);
            this.PcxWiiU.Name = "PcxWiiU";
            this.PcxWiiU.Size = new System.Drawing.Size(142, 131);
            this.PcxWiiU.TabIndex = 6;
            this.PcxWiiU.TabStop = false;
            // 
            // PcxSwitch
            // 
            this.PcxSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PcxSwitch.BackColor = System.Drawing.Color.Transparent;
            this.PcxSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxSwitch.BackgroundImage")));
            this.PcxSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxSwitch.Location = new System.Drawing.Point(53, 210);
            this.PcxSwitch.Name = "PcxSwitch";
            this.PcxSwitch.Size = new System.Drawing.Size(142, 131);
            this.PcxSwitch.TabIndex = 6;
            this.PcxSwitch.TabStop = false;
            // 
            // FmSelectSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(674, 481);
            this.Controls.Add(this.PnlSettings);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.RdWii);
            this.Controls.Add(this.RdWiiU);
            this.Controls.Add(this.RdSwitch);
            this.Controls.Add(this.PcxWii);
            this.Controls.Add(this.PcxWiiU);
            this.Controls.Add(this.PcxSwitch);
            this.Controls.Add(this.LblBody);
            this.Controls.Add(this.LblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmSelectSystem";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get My Bru";
            this.Load += new System.EventHandler(this.FmSelectSystem_Load);
            this.MtxMain.ResumeLayout(false);
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxButtonX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxButtonB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxButtonA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxALogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSwitchLogo)).EndInit();
            this.PnlSettings.ResumeLayout(false);
            this.PnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSettingsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxWii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxWiiU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxSwitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LblHeader;
        private MaterialSkin.Controls.MaterialLabel LblBody;
        private System.Windows.Forms.PictureBox PcxSwitch;
        private System.Windows.Forms.PictureBox PcxWiiU;
        private MaterialSkin.Controls.MaterialRadioButton RdSwitch;
        private MaterialSkin.Controls.MaterialRadioButton RdWiiU;
        private MaterialSkin.Controls.MaterialContextMenuStrip MtxMain;
        private System.Windows.Forms.ToolStripMenuItem openSelectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel PnlBottom;
        private MaterialSkin.Controls.MaterialLabel LblVersion;
        private System.Windows.Forms.PictureBox PcxExit;
        private MaterialSkin.Controls.MaterialLabel LblExit;
        private System.Windows.Forms.PictureBox PcxSettings;
        private MaterialSkin.Controls.MaterialLabel LblSettings;
        private System.Windows.Forms.PictureBox PcxALogo;
        private MaterialSkin.Controls.MaterialLabel LblOk;
        private System.Windows.Forms.Panel PnlSplitterFooter;
        private System.Windows.Forms.PictureBox PcxSwitchLogo;
        private System.Windows.Forms.PictureBox PcxButtonX;
        private System.Windows.Forms.PictureBox PcxButtonB;
        private System.Windows.Forms.PictureBox PcxButtonA;
        private System.Windows.Forms.PictureBox PcxWii;
        private MaterialSkin.Controls.MaterialRadioButton RdWii;
        private System.Windows.Forms.Panel PnlSettings;
        private System.Windows.Forms.Timer TmrCheckVal;
        private MaterialSkin.Controls.MaterialLabel LblSettingsHeader;
        private MaterialSkin.Controls.MaterialCheckBox ChckAutoUpdate;
        private System.Windows.Forms.Panel PnlSplitterHeader;
        private System.Windows.Forms.PictureBox PcxSettingsIcon;
        private MaterialSkin.Controls.MaterialCheckBox ChckClean;
        private System.Windows.Forms.Panel PnlSplitterMid;
        private MaterialSkin.Controls.MaterialRadioButton RdStable;
        private MaterialSkin.Controls.MaterialLabel LblBranch;
        private MaterialSkin.Controls.MaterialRadioButton RdCanary;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCheckBox ChckNotif;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDrive;
        public System.Windows.Forms.NotifyIcon NtfMain;
    }
}
