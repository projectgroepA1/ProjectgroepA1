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
        private TcpClient client;
        private NetworkStream stream;
        private Connection connection;

        public Form1(TcpClient client, NetworkStream stream)
        {
            InitializeComponent();
            this.client = client;
            this.stream = stream;
            connection = new Connection(this);
            chatTextBox.Select();
            Thread t = new Thread(() => connection.Run());
            t.Start();
        }

        public TextBox ReturnRPM()
        {
            return RPMTextbox;
        }

        public TextBox returnActualPowerTextBox()
        {
            return actualPowerTextBox;
        }

        private void RpmTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string s = RPMTextbox.Text;
                actualPowerTextBox.Text = "test";
            }
        }
    }
}
