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

namespace MonitoringApp_V2
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public NetworkStream stream { get; }
        private Login login;
        public List<Client> clients { get; }
        public Thread thread { get; }
        private Connection connection;

        public Form1(TcpClient client, NetworkStream stream, Login login)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.client = client;
            this.stream = stream;
            this.login = login;
            clients = new List<Client>();
            connection = new Connection(this);
            thread = new Thread(() => connection.Run());
            thread.Start();
            KeyPreview = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            foreach (Client client in clients)
            {
                if (e.KeyCode == Keys.Enter && client.Panel.ReturnRPM().Focused)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                    client.Panel.ReturnChatInputTextBox().Select();
                }
                if (e.KeyCode == Keys.Enter && client.Panel.ReturnDistanceTextBox().Focused)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                    client.Panel.ReturnChatInputTextBox().Select();
                }

                if (e.KeyCode == Keys.Enter && client.Panel.ReturnTimeTextBox().Focused)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                    client.Panel.ReturnChatInputTextBox().Select();
                }

                if (e.KeyCode == Keys.Enter && client.Panel.ReturnChatInputTextBox().Focused)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                    client.Panel.ReturnChatInputTextBox().Select();
                    string chatText = client.Panel.ReturnChatInputTextBox().Text;
                    if (client.Panel.ReturnFirstTime() && !(chatText.Length <= 0))
                    {
                        client.Panel.ReturnChatTextBox().Text = chatText;
                        client.Panel.changeFirstTime(false);
                    }
                    else if (!(chatText.Length <= 0))
                    {
                        client.Panel.ReturnChatTextBox().Text += Environment.NewLine + chatText;
                    }
                    client.Panel.ReturnChatInputTextBox().Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataPanel panel = new DataPanel(this);
            Client client = new Client("test", 123, panel);
            clients.Add(client);
            Invoke((Action)(() =>
            {
                flowLayoutPanel.Controls.Add(panel);
            }
                ));
        }

        public void NewClient(PacketNewClient newClient)
        {
            MessageBox.Show("Yeah new client");
            DataPanel panel = new DataPanel(this);
            Client client = new Client(newClient.usename, newClient.counter,panel);
            clients.Add(client);
            Invoke((Action) (() =>
            {
                flowLayoutPanel.Controls.Add(panel);
            }
                ));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
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
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
