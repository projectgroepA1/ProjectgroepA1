using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;
using NetLib;

namespace MonitoringApp_V2
{
    public partial class NewSession : Form
    {
        private DataPanel panel;
        private Connection connection;

        public NewSession(DataPanel panel,Connection connection)
        {
            InitializeComponent();
            this.panel = panel;
            this.connection = connection;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //creating packets
            PacketBicycleCommand PD = new PacketBicycleCommand($"PD {this.distanceTextBox.Text}",panel.id.Id);
            connection.writePacket(PD);
            PacketBicycleCommand PT = new PacketBicycleCommand($"PT {this.timeTextBox.Text}", panel.id.Id);
            connection.writePacket(PT);
            PacketBicycleCommand PW = new PacketBicycleCommand($"PW {this.PowerTextBox.Text}", panel.id.Id);
            connection.writePacket(PW);

            this.Hide();
            PowerTextBox.Clear();
            timeTextBox.Clear();
            distanceTextBox.Clear();
        }
    }
}
