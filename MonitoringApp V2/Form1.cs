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

namespace MonitoringApp_V2
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Login login;
        public List<DataPanel> panels { get; }
        private Thread thread;
        private Connection connection;

        public Form1(TcpClient client, NetworkStream stream, Login login)
        {
            InitializeComponent();
            this.client = client;
            this.stream = stream;
            this.login = login;
            panels = new List<DataPanel>();
            connection = new Connection(this);
            thread = new Thread(() => connection.Run());
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataPanel panel = new DataPanel(this);
            panels.Add(panel);
            flowLayoutPanel.Controls.Add(panel);
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            thread.Abort();
            login.Show();
            login.ClearBoxes();
        }
    }
}
