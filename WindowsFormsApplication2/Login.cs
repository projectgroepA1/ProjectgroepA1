using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
<<<<<<< HEAD
        private TcpClient client;
        private string username;
        private string password;
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
=======
        public Login()
        {
            InitializeComponent();
>>>>>>> parent of a92cdd6... tcp geadd
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            client = new TcpClient(Info.GetIp().ToString(), Info.Port);
            username = userNameTextBox.Text;
            password = passwordTextBox.Text;

            new BinaryFormatter().Serialize(client.GetStream(),new PacketMonitor());

            new Form1(client,this).Show();
=======
            new Form1().Show();
>>>>>>> parent of a92cdd6... tcp geadd
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
