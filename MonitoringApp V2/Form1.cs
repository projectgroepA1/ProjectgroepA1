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
        public TcpClient Client { get; }
        public NetworkStream stream { get; }
        private Login login;
        public List<Client> clients { get; }
        public Thread thread { get; }
        private Connection connection;

        public Form1(TcpClient client, NetworkStream stream, Login login)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Client = client;
            this.stream = stream;
            this.login = login;
            clients = new List<Client>();
            connection = new Connection(this);
            thread = new Thread(() => connection.Run());
            thread.Start();
            KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataPanel panel = new DataPanel(this,connection);
            Client client = new Client(new Identifier("test", 123), panel);

            clients.Add(client);
            Invoke((Action)(() =>
            {
                flowLayoutPanel.Controls.Add(panel);
            }
                ));
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
