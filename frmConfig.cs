using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollOnVol
{
    public partial class frmConfig : Form
    {
        RegistryKey rk = Registry.CurrentUser.OpenSubKey
        ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public frmConfig()
        {
            InitializeComponent();
        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartup.Checked) 
            {
                rk.SetValue(Application.ProductName, Application.ExecutablePath);
            } else
            {
                rk.DeleteValue(Application.ProductName, false);
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            if (rk.GetValue(Application.ProductName, null) != null)
            {
                chkStartup.Checked = true;
            } else
            {
                chkStartup.Checked = false;
            }
        }
    }
}
