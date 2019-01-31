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
            this.TbSel = new MaterialSkin.Controls.MaterialTabSelector();
            this.TbPage = new MaterialSkin.Controls.MaterialTabControl();
            this.TbHome = new System.Windows.Forms.TabPage();
            this.TbLoad = new System.Windows.Forms.TabPage();
            this.TbGame = new System.Windows.Forms.TabPage();
            this.TbEmu = new System.Windows.Forms.TabPage();
            this.TbTools = new System.Windows.Forms.TabPage();
            this.TbConc = new System.Windows.Forms.TabPage();
            this.TbAdv = new System.Windows.Forms.TabPage();
            this.TbPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbSel
            // 
            this.TbSel.BaseTabControl = this.TbPage;
            this.TbSel.Depth = 0;
            this.TbSel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbSel.Location = new System.Drawing.Point(0, 63);
            this.TbSel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbSel.Name = "TbSel";
            this.TbSel.Size = new System.Drawing.Size(1011, 41);
            this.TbSel.TabIndex = 3;
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
            this.TbPage.Location = new System.Drawing.Point(0, 104);
            this.TbPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbPage.Name = "TbPage";
            this.TbPage.SelectedIndex = 0;
            this.TbPage.Size = new System.Drawing.Size(1011, 642);
            this.TbPage.TabIndex = 2;
            // 
            // TbHome
            // 
            this.TbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TbHome.Location = new System.Drawing.Point(4, 22);
            this.TbHome.Name = "TbHome";
            this.TbHome.Size = new System.Drawing.Size(1003, 616);
            this.TbHome.TabIndex = 0;
            this.TbHome.Text = "Home";
            // 
            // TbLoad
            // 
            this.TbLoad.Location = new System.Drawing.Point(4, 22);
            this.TbLoad.Name = "TbLoad";
            this.TbLoad.Size = new System.Drawing.Size(1003, 616);
            this.TbLoad.TabIndex = 1;
            this.TbLoad.Text = "Loaders";
            this.TbLoad.UseVisualStyleBackColor = true;
            // 
            // TbGame
            // 
            this.TbGame.Location = new System.Drawing.Point(4, 22);
            this.TbGame.Name = "TbGame";
            this.TbGame.Size = new System.Drawing.Size(1003, 616);
            this.TbGame.TabIndex = 2;
            this.TbGame.Text = "Games";
            this.TbGame.UseVisualStyleBackColor = true;
            // 
            // TbEmu
            // 
            this.TbEmu.Location = new System.Drawing.Point(4, 22);
            this.TbEmu.Name = "TbEmu";
            this.TbEmu.Size = new System.Drawing.Size(1003, 616);
            this.TbEmu.TabIndex = 3;
            this.TbEmu.Text = "Emulators";
            this.TbEmu.UseVisualStyleBackColor = true;
            // 
            // TbTools
            // 
            this.TbTools.Location = new System.Drawing.Point(4, 22);
            this.TbTools.Name = "TbTools";
            this.TbTools.Size = new System.Drawing.Size(1003, 616);
            this.TbTools.TabIndex = 4;
            this.TbTools.Text = "Tools";
            this.TbTools.UseVisualStyleBackColor = true;
            // 
            // TbConc
            // 
            this.TbConc.Location = new System.Drawing.Point(4, 22);
            this.TbConc.Name = "TbConc";
            this.TbConc.Size = new System.Drawing.Size(1003, 616);
            this.TbConc.TabIndex = 5;
            this.TbConc.Text = "Concepts";
            this.TbConc.UseVisualStyleBackColor = true;
            // 
            // TbAdv
            // 
            this.TbAdv.Location = new System.Drawing.Point(4, 22);
            this.TbAdv.Name = "TbAdv";
            this.TbAdv.Size = new System.Drawing.Size(1003, 616);
            this.TbAdv.TabIndex = 6;
            this.TbAdv.Text = "Advanced";
            this.TbAdv.UseVisualStyleBackColor = true;
            // 
            // FmWiiUMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1011, 746);
            this.Controls.Add(this.TbSel);
            this.Controls.Add(this.TbPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmWiiUMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmWiiUMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmWiiUMain_FormClosing);
            this.TbPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector TbSel;
        private MaterialSkin.Controls.MaterialTabControl TbPage;
        private System.Windows.Forms.TabPage TbHome;
        private System.Windows.Forms.TabPage TbLoad;
        private System.Windows.Forms.TabPage TbGame;
        private System.Windows.Forms.TabPage TbEmu;
        private System.Windows.Forms.TabPage TbTools;
        private System.Windows.Forms.TabPage TbConc;
        private System.Windows.Forms.TabPage TbAdv;
    }
}