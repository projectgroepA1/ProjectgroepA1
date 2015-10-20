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
using System.Threading;

namespace MonitoringApp_V2
{
    public partial class NewSession : Form
    {
        private DataPanel panel;
        private Connection connection;

        public NewSession(DataPanel panel, Connection connection)
        {
            InitializeComponent();
            this.panel = panel;
            this.connection = connection;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //creating packets
            //Resetting Bike to set time and distance
            PacketBicycleCommand RS = new PacketBicycleCommand("RS", panel.id.Id);
            connection.writePacket(RS);
            //Waiting 5 secs to let bike reboot
            Thread.Sleep(5000);
            //Entering command mode to insert P- Commands
            PacketBicycleCommand CM = new PacketBicycleCommand("CM", panel.id.Id);
            connection.writePacket(CM);
            //Set required Distance
            PacketBicycleCommand PD = new PacketBicycleCommand($"PD {this.distanceTextBox.Text}", panel.id.Id);
            connection.writePacket(PD);
            //Set required Time
            PacketBicycleCommand PT = new PacketBicycleCommand($"PT {this.timeTextBox.Text}", panel.id.Id);
            connection.writePacket(PT);
            //Set power level
            PacketBicycleCommand PW = new PacketBicycleCommand($"PW {this.PowerTextBox.Text}", panel.id.Id);
            connection.writePacket(PW);

            PacketChat chat = new PacketChat("SESSION STARTED", panel.id.Username, "client", panel.id.Id);
            connection.writePacket(chat);

            foreach (var series in panel.returnChart().Series)
            {
                series.Points.Clear();
            }

            this.Hide();
            PowerTextBox.Clear();
            timeTextBox.Clear();
            distanceTextBox.Clear();
        }

        private void SetPower_Click(object sender, EventArgs e)
        {
            PacketBicycleCommand PW = new PacketBicycleCommand($"PW {this.PowerTextBox.Text}", panel.id.Id);
            connection.writePacket(PW);

            this.Hide();
            PowerTextBox.Clear();
            timeTextBox.Clear();
            distanceTextBox.Clear();
        }
    }
}
