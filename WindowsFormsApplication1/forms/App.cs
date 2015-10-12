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
        public Communication reader { get; }

        private ServerConnection serverConnection;

        private OrderedDictionary pulseList = new OrderedDictionary();
        private Dictionary<int, int> rpmList = new Dictionary<int, int>();
        private Dictionary<int, int> speedList = new Dictionary<int, int>();
        private Dictionary<int, int> distanceList = new Dictionary<int, int>();
        private Dictionary<int, int> powerList = new Dictionary<int, int>();
        private Dictionary<int, int> energyList = new Dictionary<int, int>();
        private Dictionary<int, int> timeList = new Dictionary<int, int>();
        private Dictionary<int, int> actualpowerList = new Dictionary<int, int>();

        public Client(ServerConnection serverConnection)
        {
            InitializeComponent();

            this.serverConnection = serverConnection;

            this.serverConnection.client = this;


            //start the reader
            this.reader = new Communication("COM2");

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
                    int I_time = Int32.Parse(_time);
                    int I_actualPower = Int32.Parse(_actualPower);

                    //Filling dictionary's
                    pulseList.Add(I_time, I_pulse);
                    rpmList.Add(I_time, I_rpm);
                    speedList.Add(I_time, I_speed);
                    distanceList.Add(I_time, I_distance);
                    powerList.Add(I_time, I_power);
                    energyList.Add(I_time, I_energy);
                    timeList.Add(I_time, I_time);
                    actualpowerList.Add(I_time, I_actualPower);

                    //Adding coördinates to chart
                    this.Grafiek.Series["Pulse"].Points.AddXY(I_time, I_pulse);
                    this.Grafiek.Series["Rpm"].Points.AddXY(I_time, I_rpm);
                    this.Grafiek.Series["Speed"].Points.AddXY(I_time, I_speed);
                    this.Grafiek.Series["Distance"].Points.AddXY(I_time, I_distance);
                    this.Grafiek.Series["Power"].Points.AddXY(I_time, I_power);
                    this.Grafiek.Series["Energy"].Points.AddXY(I_time, I_energy);
                    this.Grafiek.Series["Time"].Points.AddXY(I_time, I_time);
                    this.Grafiek.Series["Actual_Power"].Points.AddXY(I_time, I_actualPower);

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
    }
}
