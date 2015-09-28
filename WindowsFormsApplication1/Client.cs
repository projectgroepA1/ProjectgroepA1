using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetLib;

namespace WindowsFormsApplication1
{
    public partial class Client : Form, ClientInterface
    {
        private TcpClient client;
        private NetworkStream stream;

        public Client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new TcpClient("localhost", 1000);
            stream = client.GetStream();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Packet loginPacket = new PacketLogin() { username = "Johan", password = "Johan" };
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, loginPacket);
        }

        public void loginResponse(bool loginOk)
        {
            if (loginOk)
                MessageBox.Show("Login is ok");
            else
                MessageBox.Show("Login is niet ok");
        }
    }
}
