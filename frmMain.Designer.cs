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
            this.SuspendLayout();
            // 
            // sclVolume
            // 
            this.sclVolume.LargeChange = 20;
            this.sclVolume.Location = new System.Drawing.Point(9, 13);
            this.sclVolume.Name = "sclVolume";
            this.sclVolume.Size = new System.Drawing.Size(151, 19);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 68);
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
    }
}

