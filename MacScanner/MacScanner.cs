using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacScanner
{
    public partial class MacScanner : Form
    {
        public MacScanner()
        {
            InitializeComponent();
            toolTip.SetToolTip(MACTextBox, "Enter the manufacturers MAC address part and press 'Scan'.\nFormat FF:FF:FF or FF-FF-FF.");
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            //some stuff
        }
    }
}
