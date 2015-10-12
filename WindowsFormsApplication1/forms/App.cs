using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.networking;
using NetLib;

namespace ClientApp
{
    public partial class Client : Form
    {

        public Communication reader;

        private ServerConnection serverConnection;
        public Thread Thread { get; }

        public Client(ServerConnection serverConnection)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.serverConnection = serverConnection;

            //Start serial port reader
            this.reader = new Communication("COM3");
            this.serverConnection.client = this;
            
            //Start gui updater
            Thread thread = new Thread(new ThreadStart(UpdateGui));
            thread.Start();
        }

        private void UpdateGui()
        {
            while (true)
            {
                if (reader.parts != null && reader.parts.Length > 7)
                {
                    //Create and send measurement packet
                    PacketMeasurement measurement = new PacketMeasurement(int.Parse(reader.parts[0]), int.Parse(reader.parts[0]), int.Parse(reader.parts[0]), reader.parts[0], reader.parts[0], int.Parse(reader.parts[0]), reader.parts[0], int.Parse(reader.parts[0]));
                    this.serverConnection.WritePacket(measurement);

                    Console.WriteLine("reader size: " + reader.parts.Length);
                    //read all parts
                    string _pulse = reader.parts[0];
                    string _rpm = reader.parts[1];
                    string _speed = reader.parts[2];
                    string _distance = reader.parts[3];
                    string _power = reader.parts[4];
                    string _energy = reader.parts[5];
                    string _time = reader.parts[6];
                    string _actualPower = reader.parts[7];

                    //Update textboxes
                    MethodInvoker mi1 = delegate () { this.pulse.Text = _pulse; };
                    this.Invoke(mi1);
                    MethodInvoker mi2 = delegate () { this.rpm.Text = _rpm; };
                    this.Invoke(mi2);
                    MethodInvoker mi3 = delegate () { this.speed.Text = _speed; };
                    this.Invoke(mi3);
                    MethodInvoker mi4 = delegate () { this.distance.Text = _distance; };
                    this.Invoke(mi4);
                    MethodInvoker mi5 = delegate () { this.power.Text = _power; };
                    this.Invoke(mi5);
                    MethodInvoker mi6 = delegate () { this.energy.Text = _energy; };
                    this.Invoke(mi6);
                    MethodInvoker mi7 = delegate () { this.time.Text = _time; };
                    this.Invoke(mi7);
                    MethodInvoker mi8 = delegate () { this.actualpower.Text = _actualPower; };
                    this.Invoke(mi8);

                    //Parse all strings to int
                    int I_pulse = Int32.Parse(_pulse);
                    int I_rpm = Int32.Parse(_rpm);
                    int I_speed = Int32.Parse(_speed);
                    int I_distance = Int32.Parse(_distance);
                    int I_power = Int32.Parse(_power);
                    int I_energy = Int32.Parse(_energy);
                    TimeSpan ts = TimeSpan.Parse(_time);
                    int I_sec = ts.Seconds;
                    int I_min = ts.Minutes;
                    int I_actualPower = Int32.Parse(_actualPower);

                    //Adding coördinates to chart
                    MethodInvoker miP = delegate () { this.Grafiek.Series["Pulse"].Points.AddXY(I_sec, I_pulse); };
                    this.Invoke(miP);
                    MethodInvoker miR = delegate () { this.Grafiek.Series["Rpm"].Points.AddXY(I_sec, I_rpm); };
                    this.Invoke(miR);
                    MethodInvoker miS = delegate () { this.Grafiek.Series["Speed"].Points.AddXY(I_sec, I_speed); };
                    this.Invoke(miS);
                    MethodInvoker miD = delegate () { this.Grafiek.Series["Distance"].Points.AddXY(I_sec, I_distance); };
                    this.Invoke(miD);
                    MethodInvoker miPo = delegate () { this.Grafiek.Series["Power"].Points.AddXY(I_sec, I_power); };
                    this.Invoke(miPo);
                    MethodInvoker miE = delegate () { this.Grafiek.Series["Energy"].Points.AddXY(I_sec, I_energy); };
                    this.Invoke(miE);
                    MethodInvoker miAP = delegate () { this.Grafiek.Series["ActualPower"].Points.AddXY(I_sec, I_actualPower); };
                    this.Invoke(miAP);

                    //Wait 1 second
                    Thread.Sleep(1000);
                }
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chatbox.AppendText(this.Sendbox.Text + Environment.NewLine);

                //send packet to the server
                PacketChat chat = new PacketChat(this.Sendbox.Text + Environment.NewLine);
                this.serverConnection.WritePacket(chat);

                Chatbox.TextAlign = HorizontalAlignment.Right;
                Sendbox.Clear();
            }
        }

        public void appendTextToChat(string message)
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(delegate
                {
                    this.Chatbox.Text += message;
                });
                this.Invoke(method);
            }
            else
            {
                this.Chatbox.Text += message;
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverConnection.WritePacket(new PacketDisconnect() { disconnected = true });
        }
    }
}
