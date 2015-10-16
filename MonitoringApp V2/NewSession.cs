using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringApp_V2
{
    public partial class NewSession : Form
    {
        private DataPanel panel;

        public NewSession(DataPanel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            panel.form.sendSession(actualPowerTextBox.Text, timeTextBox.Text, distanceTextBox.Text);
        }
    }
}
