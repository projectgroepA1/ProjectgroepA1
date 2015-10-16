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

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        private TcpClient client;
        private string username;
        private string password;
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    
        private void loginButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient(Info.GetIp().ToString(), Info.Port);
            username = userNameTextBox.Text;
            password = passwordTextBox.Text;

            new BinaryFormatter().Serialize(client.GetStream(),new PacketMonitor());

            new Form1(client,this).Show();
            this.Hide();
        }

        public void Init()
        {
            new BinaryFormatter().Serialize(client.GetStream(), new PacketDisconnect() {disconnected = true});
            client.Close();  
            client = null;
            userNameTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
