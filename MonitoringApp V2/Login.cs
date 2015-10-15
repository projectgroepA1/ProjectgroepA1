using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitoringApp_V2;
using NetLib;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string username;
        private string password;

        public Login()
        {
            InitializeComponent();
/*            try
            {
                client = new TcpClient("127.0.0.1", 1000);
                stream = client.GetStream();
            }
            catch (Exception)
            {
                MessageBox.Show("No connection with the server");
                Thread.CurrentThread.Abort();
            }*/
        }
    
        private void loginButton_Click(object sender, EventArgs e)
        {
/*            Packet loginPacket = new PacketLogin() { username ="test", password = "Johan" };
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, loginPacket);*/
            new Form1(client, stream, this).Show();
            this.Hide();
        }

        public void ClearBoxes()
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
