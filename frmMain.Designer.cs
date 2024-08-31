namespace RollOnVol
{
    partial class frmMain
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
            this.sclVolume = new System.Windows.Forms.HScrollBar();
            this.tmrOpacity = new System.Windows.Forms.Timer(this.components);
            this.cmdConfig = new System.Windows.Forms.Button();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sclVolume
            // 
            this.sclVolume.LargeChange = 20;
            this.sclVolume.Location = new System.Drawing.Point(9, 9);
            this.sclVolume.Name = "sclVolume";
            this.sclVolume.Size = new System.Drawing.Size(180, 23);
            this.sclVolume.SmallChange = 5;
            this.sclVolume.TabIndex = 0;
            this.sclVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sclVolume_Scroll);
            // 
            // tmrOpacity
            // 
            this.tmrOpacity.Interval = 250;
            this.tmrOpacity.Tag = "1";
            this.tmrOpacity.Tick += new System.EventHandler(this.tmrOpacity_Tick);
            // 
            // cmdConfig
            // 
            this.cmdConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConfig.Image = global::RollOnVol.Properties.Resources.tools_line;
            this.cmdConfig.Location = new System.Drawing.Point(9, 44);
            this.cmdConfig.Name = "cmdConfig";
            this.cmdConfig.Size = new System.Drawing.Size(24, 24);
            this.cmdConfig.TabIndex = 1;
            this.cmdConfig.UseVisualStyleBackColor = true;
            this.cmdConfig.Click += new System.EventHandler(this.cmdConfig_Click);
            // 
            // chkMute
            // 
            this.chkMute.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMute.Image = global::RollOnVol.Properties.Resources.volume_mute_line;
            this.chkMute.Location = new System.Drawing.Point(39, 44);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(24, 23);
            this.chkMute.TabIndex = 2;
            this.chkMute.UseVisualStyleBackColor = true;
            this.chkMute.CheckedChanged += new System.EventHandler(this.chkMute_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 80);
            this.Controls.Add(this.chkMute);
            this.Controls.Add(this.cmdConfig);
            this.Controls.Add(this.sclVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Opacity = 0.5D;
            this.ShowInTaskbar = false;
            this.Text = "RollOnVol 0.1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar sclVolume;
        private System.Windows.Forms.Timer tmrOpacity;
        private System.Windows.Forms.Button cmdConfig;
        private System.Windows.Forms.CheckBox chkMute;
    }
}

