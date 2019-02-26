namespace GetMyBru.GetMyBru.GUI
{
    partial class FmHomebrewInfo
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
            this.PnlInfo = new System.Windows.Forms.Panel();
            this.LblInfo = new MaterialSkin.Controls.MaterialLabel();
            this.LblInfoBody = new MaterialSkin.Controls.MaterialLabel();
            this.LblInfoHeader = new MaterialSkin.Controls.MaterialLabel();
            this.PcxInfoIcon = new System.Windows.Forms.PictureBox();
            this.BtnInstall = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnClose = new MaterialSkin.Controls.MaterialFlatButton();
            this.PnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxInfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlInfo
            // 
            this.PnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PnlInfo.Controls.Add(this.BtnClose);
            this.PnlInfo.Controls.Add(this.BtnInstall);
            this.PnlInfo.Controls.Add(this.LblInfo);
            this.PnlInfo.Controls.Add(this.LblInfoBody);
            this.PnlInfo.Controls.Add(this.LblInfoHeader);
            this.PnlInfo.Controls.Add(this.PcxInfoIcon);
            this.PnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlInfo.Location = new System.Drawing.Point(0, 0);
            this.PnlInfo.Name = "PnlInfo";
            this.PnlInfo.Size = new System.Drawing.Size(769, 531);
            this.PnlInfo.TabIndex = 12;
            this.PnlInfo.Visible = false;
            // 
            // LblInfo
            // 
            this.LblInfo.Depth = 0;
            this.LblInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblInfo.ForeColor = System.Drawing.Color.White;
            this.LblInfo.Location = new System.Drawing.Point(25, 241);
            this.LblInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(732, 157);
            this.LblInfo.TabIndex = 3;
            this.LblInfo.Text = "%APPINFORMATION%\r\n\r\n%VERSION%\r\n%CREATOR% \r\n%UPDATED%\r\n%COMMIT% \r\n%GITURL% ";
            this.LblInfo.Visible = false;
            // 
            // LblInfoBody
            // 
            this.LblInfoBody.Depth = 0;
            this.LblInfoBody.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblInfoBody.ForeColor = System.Drawing.Color.White;
            this.LblInfoBody.Location = new System.Drawing.Point(227, 75);
            this.LblInfoBody.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblInfoBody.Name = "LblInfoBody";
            this.LblInfoBody.Size = new System.Drawing.Size(531, 151);
            this.LblInfoBody.TabIndex = 2;
            this.LblInfoBody.Text = "%APPDESCBODY%";
            this.LblInfoBody.Visible = false;
            // 
            // LblInfoHeader
            // 
            this.LblInfoHeader.Depth = 0;
            this.LblInfoHeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblInfoHeader.ForeColor = System.Drawing.Color.White;
            this.LblInfoHeader.Location = new System.Drawing.Point(226, 33);
            this.LblInfoHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblInfoHeader.Name = "LblInfoHeader";
            this.LblInfoHeader.Size = new System.Drawing.Size(531, 42);
            this.LblInfoHeader.TabIndex = 1;
            this.LblInfoHeader.Text = "%APPTITLE%";
            this.LblInfoHeader.Visible = false;
            // 
            // PcxInfoIcon
            // 
            this.PcxInfoIcon.BackgroundImage = global::GetMyBru.Properties.Resources.NoImage;
            this.PcxInfoIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxInfoIcon.Location = new System.Drawing.Point(25, 33);
            this.PcxInfoIcon.Name = "PcxInfoIcon";
            this.PcxInfoIcon.Size = new System.Drawing.Size(195, 193);
            this.PcxInfoIcon.TabIndex = 0;
            this.PcxInfoIcon.TabStop = false;
            this.PcxInfoIcon.Visible = false;
            // 
            // BtnInstall
            // 
            this.BtnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInstall.AutoSize = true;
            this.BtnInstall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnInstall.Depth = 0;
            this.BtnInstall.Icon = null;
            this.BtnInstall.Location = new System.Drawing.Point(682, 483);
            this.BtnInstall.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnInstall.Name = "BtnInstall";
            this.BtnInstall.Primary = true;
            this.BtnInstall.Size = new System.Drawing.Size(75, 36);
            this.BtnInstall.TabIndex = 4;
            this.BtnInstall.Text = "install";
            this.BtnInstall.UseVisualStyleBackColor = true;
            this.BtnInstall.Visible = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.AutoSize = true;
            this.BtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClose.Depth = 0;
            this.BtnClose.Icon = null;
            this.BtnClose.Location = new System.Drawing.Point(578, 483);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Primary = false;
            this.BtnClose.Size = new System.Drawing.Size(97, 36);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close Info";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FmHomebrewInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 531);
            this.ControlBox = false;
            this.Controls.Add(this.PnlInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmHomebrewInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmHomebrewInfo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FmHomebrewInfo_Load);
            this.PnlInfo.ResumeLayout(false);
            this.PnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxInfoIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlInfo;
        private MaterialSkin.Controls.MaterialLabel LblInfo;
        private MaterialSkin.Controls.MaterialLabel LblInfoBody;
        private MaterialSkin.Controls.MaterialLabel LblInfoHeader;
        private System.Windows.Forms.PictureBox PcxInfoIcon;
        private MaterialSkin.Controls.MaterialRaisedButton BtnInstall;
        private MaterialSkin.Controls.MaterialFlatButton BtnClose;
    }
}