using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
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
        private BinaryFormatter formatter;


        public SslStream Stream { get; set; }
        X509CertificateCollection cCollection = new X509CertificateCollection();
        string server = "127.0.0.1";

        public static bool ValidateServerCertificate(object sender, X509Certificate certificate,
      X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // Accept all certificates
            return true;
        }

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("check1");
            client = new TcpClient(Info.GetIp().ToString(), Info.Port);
            cCollection.Add(new X509Certificate(AppDomain.CurrentDomain.BaseDirectory + "Cert.pfx", "MSsediqima"));
            Stream = new SslStream(client.GetStream(), false,
        new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
            Stream.AuthenticateAsClient(server, cCollection, System.Security.Authentication.SslProtocols.Default, true);

            //MessageBox.Show("check2");
            formatter = new BinaryFormatter();
            
            formatter.Serialize(Stream, new PacketMonitor());

            //MessageBox.Show("check3");
            Packet loginPacket = new PacketLogin() { username = userNameTextBox.Text, password = passwordTextBox.Text };
            
            formatter.Serialize(Stream, loginPacket);

            //MessageBox.Show("check4");
           
            PacketLoginResponse response = (PacketLoginResponse)formatter.Deserialize(Stream);
            loginResponse(response.loginOk, response.dir);
            //loginResponse(true);
        }

        public void loginResponse(bool loginOk, string dir)
        {
            if (loginOk)
            {
                new Form1(client, Stream, this, dir).Show();
                this.Hide();
            }
            else
            {
                client.Close();
                Stream.Close();
                //MessageBox.Show("The username or password is wrong");
            }
        }

        public void ClearBoxes()
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
