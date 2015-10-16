using System;
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
            //send default packet, that shows this is not an monitor
            Packet packet = new Packet();
            this.serverConnection.WritePacket(packet);

            PacketLogin loginPacket = new PacketLogin() {username = username.Text, password = password.Text};
            this.serverConnection.WritePacket(loginPacket);

            Packet _packet = this.serverConnection.ReadPacket();
            PacketLoginResponse login = _packet as PacketLoginResponse;

            if (login != null)
            {
                if (login.loginOk)
                {
                    this.Hide();
                    new Client(this.serverConnection, username.Text, login.number).Show();
                    Console.WriteLine("good login");
                }
                else
                {
                    Console.WriteLine("failed login");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
