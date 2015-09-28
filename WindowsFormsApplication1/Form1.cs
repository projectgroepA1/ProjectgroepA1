using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace WindowsFormsApplication1
    {
        public partial class Client : Form
        {
            public Client()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }
        }
    }
    //public partial class Form1 : Form, ClientInterface
    //{
    //    private TcpClient client;
    //    private NetworkStream stream;

    //    public Form1()
    //    {
    //        InitializeComponent();
    //    }

    //    private void Form1_Load(object sender, EventArgs e)
    //    {
    //        client = new TcpClient("localhost", 1000);
    //        stream = client.GetStream();
    //    }

    //    private void button1_Click(object sender, EventArgs e)
    //    {
    //        Packet loginPacket = new PacketLogin() { username = "Johan", password = "Johan" };
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        formatter.Serialize(stream, loginPacket);
    //    }

    //    public void loginResponse(bool loginOk)
    //    {
    //        if (loginOk)
    //            MessageBox.Show("Login is ok");
    //        else
    //            MessageBox.Show("Login is niet ok");
    //    }
    //}
}
