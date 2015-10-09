using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Login login;

        public Form1(TcpClient client, Login login)
        {
            InitializeComponent();
            this.client = client;
            //this.stream = client.GetStream();
            this.login = login;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
            login.ClearBoxes();
        }
    }
}
