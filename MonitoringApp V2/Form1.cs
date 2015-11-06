using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;
using NetLib;
using System.IO;

namespace MonitoringApp_V2
{
    public partial class Form1 : Form
    {
        public TcpClient Client { get; }
        public NetworkStream stream { get; }
        private Login login;
        public List<Client> clients { get; }
        public Thread thread { get; }
        private Connection connection;
        private string dir;

        public Form1(TcpClient client, NetworkStream stream, Login login, string dir)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Client = client;
            this.stream = stream;
            this.login = login;
            this.dir = dir;
            clients = new List<Client>();
            connection = new Connection(this);
            thread = new Thread(() => connection.Run());
            thread.Start();
            KeyPreview = true;
        }

        public void AddPanel(DataPanel panel)
        {
            Invoke((Action)(() =>
            {
                flowLayoutPanel.Controls.Add(panel);
            }
                ));
        }

        public void showMessage(int clientID, string message)
        {
            foreach(Client client in clients)
            {
                if(clientID == client.Identifier.Id)
                {
                    client.Panel.changeChatBoxText(message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            closeApplicaton();
            login.Show();
            login.ClearBoxes();
        }

        public void closeApplicaton()
        {
            thread.Abort();
            Thread.CurrentThread.Abort();
            Application.Exit();
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FileLoader(this, connection).Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        public void LoadMeasurements(List<Measurement> mes)
        {
            DataPanel panel = new DataPanel(this, connection, new Identifier("test", 123));
            List<Measurement> measurements = mes;

            Invoke((Action)(() =>
            {
                flowLayoutPanel.Controls.Add(panel);

                foreach (Measurement measurement in measurements)
                {
                    string _pulse = measurement.pulse;
                    string _rpm = measurement.RPM;
                    string _speed = measurement.speed;
                    string _distance = measurement.distance;
                    string _power = measurement.power;
                    string _energy = measurement.energy;
                    string _time = measurement.time;
                    string _actualPower = measurement.AP;


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
                    MethodInvoker miP = delegate () { panel.returnChart().Series["Pulse"].Points.AddXY(I_sec, I_pulse); };
                    panel.Invoke(miP);
                    MethodInvoker miR = delegate () { panel.returnChart().Series["RPM"].Points.AddXY(I_sec, I_rpm); };
                    panel.Invoke(miR);
                    MethodInvoker miS = delegate () { panel.returnChart().Series["Speed"].Points.AddXY(I_sec, I_speed); };
                    panel.Invoke(miS);
                    MethodInvoker miD = delegate () { panel.returnChart().Series["Distance"].Points.AddXY(I_sec, I_distance); };
                    panel.Invoke(miD);
                    MethodInvoker miPo = delegate () { panel.returnChart().Series["Power"].Points.AddXY(I_sec, I_power); };
                    panel.Invoke(miPo);
                    MethodInvoker miE = delegate () { panel.returnChart().Series["Energy"].Points.AddXY(I_sec, I_energy); };
                    panel.Invoke(miE);
                    MethodInvoker miAP = delegate () { panel.returnChart().Series["Actual Power"].Points.AddXY(I_sec, I_actualPower); };
                    panel.Invoke(miAP);
                }
            }
                ));
        }

        private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewClient().Show();
        }
    }
}
