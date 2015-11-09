using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using ClientApp.forms;
using ClientApp.networking;
using NetLib;

namespace ClientApp
{
    public partial class Client : Form
    {
        public Communication reader;

        public int id { get; }

        public ServerConnection serverConnection { get; }

        public Thread fromServer { get; }

        public string hostName { get; }

        private bool updateGui_Flag = false;

        private List<Tuple<int, int, int, int, int, int, int>> Values;

        public Client(ServerConnection serverConnection, string hostName, int id)
        {
            InitializeComponent();
            this.id = id;
            this.hostName = hostName;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.serverConnection = serverConnection;

            //Start serial port reader
            this.reader = new Communication("COM4");

            this.serverConnection.client = this;

            fromServer = new Thread(new ThreadStart(PacketsFromServer));
            fromServer.Start();

            Values = new List<Tuple<int, int, int, int, int, int, int>>();
        }

        private void PacketsFromServer()
        {
            while (true)
            {
                serverConnection.ReadPacket().handleClientSide(serverConnection);
            }
        }

        private void UpdateGui()
        {
            while (updateGui_Flag)
            {
                if (reader.parts[7] != null)
                {
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
                    InsertTime(_time);
                    MethodInvoker mi8 = delegate () { this.actualpower.Text = _actualPower; };
                    this.Invoke(mi8);

                    //Parse all strings to int
                    int I_pulse = Int32.Parse(_pulse);
                    int I_rpm = Int32.Parse(_rpm);
                    int I_speed = Int32.Parse(_speed);
                    int I_distance = Int32.Parse(_distance);
                    int I_power = Int32.Parse(_power);
                    int I_energy = Int32.Parse(_energy);
                    int I_actualPower = Int32.Parse(_actualPower);

                    //Fill Values tuple list
                    Values.Add(new Tuple<int, int, int, int, int, int, int>(I_pulse, I_rpm, I_speed, I_distance, I_power, I_energy, I_actualPower));

                    //time
                    TimeSpan ts = TimeSpan.Parse(_time);
                    int I_sec = ts.Seconds;

                    //Create and send measurement packet
                    PacketMeasurement measurement = new PacketMeasurement(_pulse, _rpm, _speed, _distance, _power,
                        _energy, _time, _actualPower);
                    this.serverConnection.WritePacket(measurement);

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

        public void InsertTime(string _time)
        {
            MethodInvoker mi7 = delegate () { this.time.Text = _time; };
            this.Invoke(mi7);
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chatbox.AppendText("[you] " + this.Sendbox.Text + Environment.NewLine);

                //send packet to the server
                PacketChat chat = new PacketChat(this.Sendbox.Text + Environment.NewLine, hostName, "monitor", id);
                this.serverConnection.WritePacket(chat);
                Console.WriteLine("Sent message");
                Sendbox.Clear();
            }
        }

        public void appendTextToChat(string message)
        {
            //session check
            if (message == "[doctor] " + "Session started...")
            {
                GuiStarter();
            }
            else if (message == "[doctor] " + "Session ended...")
            {
                updateGui_Flag = false;
                //Send list<tuple> of values
                serverConnection.SendHistoryPacket(Values);
            }

            //the appendtextToChat method handler
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(delegate
                {
                    this.Chatbox.Text += message + Environment.NewLine;
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

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void GuiStarter()
        {

            foreach (var series in this.Grafiek.Series)
            {
                MethodInvoker clear = delegate () { series.Points.Clear(); ; };
                this.Invoke(clear);
            }
            updateGui_Flag = true;
            Thread.Sleep(1000);
            Thread thread = new Thread(new ThreadStart(UpdateGui));
            thread.Start();
        }

        private void sessions_button_Click(object sender, EventArgs e)
        {
            SessionsChooser chooser = new SessionsChooser(this);
            chooser.ShowDialog(this);
        }
    }
}