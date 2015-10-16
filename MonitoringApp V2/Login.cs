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
        private BinaryFormatter formatter;
        private string username;
        private string password;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            try
            {
                client = new TcpClient(Info.GetIp().ToString(), Info.Port);
                stream = client.GetStream();
            }
            catch (Exception)
            {
                MessageBox.Show("No connection with the server");
                Thread.CurrentThread.Abort();
            }
        }
    
        private void loginButton_Click(object sender, EventArgs e)
        {
            Packet loginPacket = new PacketLogin() { username = userNameTextBox.Text, password = passwordTextBox.Text};
            formatter = new BinaryFormatter();
            formatter.Serialize(stream, loginPacket);
            PacketLoginResponse response = (PacketLoginResponse)formatter.Deserialize(stream);
            loginResponse(response.loginOk);
            //loginResponse(true);
        }

        public void loginResponse(bool loginOk)
        {
            if (loginOk)
            {
                new Form1(client, stream, this).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is wrong");
            }
        }

        public void ClearBoxes()
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
