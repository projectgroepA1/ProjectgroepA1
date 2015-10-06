using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.networking;
using NetLib;

namespace ClientApp.forms
{
    public partial class Login : Form
    {
        private ServerConnection serverConnection;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //start connection
            this.serverConnection = new ServerConnection();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            PacketLogin loginPacket = new PacketLogin() {username = username.Text, password = password.Text};
            this.serverConnection.WritePacket(loginPacket);

            Packet packet = this.serverConnection.ReadPacket();
            PacketLoginResponse login = packet as PacketLoginResponse;

            if (login != null)
            {
                if (login.loginOk)
                {
                    Console.WriteLine("good login");
                    this.Hide();
                    new Client(this.serverConnection).Show();
                }
                else
                {
                    Console.WriteLine("failed login");
                }
            }
        }
    }
}
