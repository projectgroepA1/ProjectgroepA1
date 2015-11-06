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
            foreach (var series in panel.returnChart().Series)
            {
                series.Points.Clear();
            }

            if (radioButton_Time.Checked)
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
                //Set required Time
                PacketBicycleCommand PT = new PacketBicycleCommand($"PT {this.timeTextBox.Text}", panel.id.Id);
                connection.writePacket(PT);
                //Set power level
                PacketBicycleCommand PW = new PacketBicycleCommand($"PW {this.PowerTextBox.Text}", panel.id.Id);
                connection.writePacket(PW);
                //Start handling Thread
                Thread thread = new Thread(new ThreadStart(SessionHandler));
                thread.Start();
            }
            else if (radioButton_Distance.Checked)
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
                //Set power level
                PacketBicycleCommand PW = new PacketBicycleCommand($"PW {this.PowerTextBox.Text}", panel.id.Id);
                connection.writePacket(PW);
                //Start handling Thread
                Thread thread = new Thread(new ThreadStart(SessionHandler));
                thread.Start();
            }
            else
            {
                MessageBox.Show("Select the session type first!");
            }
            Hide();
        }

        private void radioButton_Time_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Time.Checked)
            {
                timeTextBox.Enabled = true;
                distanceTextBox.Enabled = false;
                distanceTextBox.Clear();
            }
        }

        private void radioButton_Distance_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Distance.Checked)
            {
                distanceTextBox.Enabled = true;
                timeTextBox.Enabled = false;
                timeTextBox.Clear();
            }
        }

        private void SessionHandler()
        {
            //Send starting chat packet
            PacketChat chat = new PacketChat("Session started...", panel.id.Username, "client", panel.id.Id);
            connection.writePacket(chat);
            if (radioButton_Time.Checked)
            {
                int tt = int.Parse(timeTextBox.Text);
                int min = tt / 100;
                int sec = tt % 100;
                bool flag = true;
                while (flag)
                {
                    //Decrease by 1 second
                    sec--;
                    //Check if seconds are over and minutes should be decreased.
                    if (sec == 0)
                    {
                        if (min == 0)
                        {
                            PacketChat end = new PacketChat("Session ended...", panel.id.Username, "client", panel.id.Id);
                            connection.writePacket(end);
                            flag = false;
                        }

                        sec = 60;
                        min--;
                    }
                    Thread.Sleep(1000);
                }
            }
            else if (radioButton_Distance.Checked)
            {
                bool flag = true;
                while (flag)
                {
                    int distance = int.Parse(panel.ReturnDistanceTextBox().Text);
                    if (distance == 0)
                    {
                        PacketChat end = new PacketChat("Session ended...", panel.id.Username, "client", panel.id.Id);
                        connection.writePacket(end);
                        flag = false;   
                    }
                }
            }
        }
    }
}
