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
            
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //start connection
            this.serverConnection = new ServerConnection();

            PacketLogin loginPacket = new PacketLogin() {username = username.Text, password = password.Text};
            this.serverConnection.WritePacket(loginPacket);

            Packet _packet = this.serverConnection.ReadPacket();
            PacketLoginResponse login = _packet as PacketLoginResponse;

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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
