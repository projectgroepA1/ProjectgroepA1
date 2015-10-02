using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public delegate TextBox returnTextBox();
        public returnTextBox returnBox;
        private TcpClient client;
        private NetworkStream stream;
        private Connection connection;

        public Form1(TcpClient client, NetworkStream stream)
        {
            InitializeComponent();
            this.client = client;
            this.stream = stream;
            returnBox = new returnTextBox(ReturnRPM);
            connection = new Connection(this);
            Thread t = new Thread(() => connection.Run());
            t.Start();
        }

        public TextBox ReturnRPM()
        {
            return RPMTextbox;
        }
    }
}
