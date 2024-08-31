using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace RollOnVol
{
    public partial class frmMain : Form
    {
        public double chOp = 0.5;


        CoreAudioDevice defRollOn = new CoreAudioController().DefaultPlaybackDevice;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //App exit in 'Esc' key
            if (e.KeyCode == Keys.Escape)
            {
                Properties.Settings.Default.lastX = this.Left;
                Properties.Settings.Default.lastY = this.Top;
                Properties.Settings.Default.Save();
                Environment.Exit(0);
            }
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Left = Properties.Settings.Default.lastX;
            this.Top = Properties.Settings.Default.lastY;
            this.TopMost = false;
        }

        private void sclVolume_Scroll(object sender, ScrollEventArgs e)
        {

            defRollOn.Volume = sclVolume.Value;

            chOp = 1;
            tmrOpacity.Enabled = true;
        }

        private void tmrOpacity_Tick(object sender, EventArgs e)
        {

            if(chOp>0.5)
            {
                chOp = chOp - 0.1;
                this.Opacity = chOp;
            } else
            {
                tmrOpacity.Enabled = false;
            }

        }
    }
}
