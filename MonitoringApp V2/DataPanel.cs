using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace MonitoringApp_V2
{
    public partial class DataPanel : Panel
    {
        private TcpClient client;
        private NetworkStream stream;
        private Connection connection;
        private bool firstTime;
        private Thread thread;
        private Form1 form;

        public DataPanel(TcpClient client, NetworkStream stream, Form1 form)
        {
            InitializeComponent();
            this.client = client;
            this.stream = stream;
            this.form = form;
            connection = new Connection(this);
            chatInputTextBox.Select();
            thread = new Thread(() => connection.Run());
            thread.Start();
            firstTime = true;
        }

        public TextBox ReturnRPM()
        {
            return RPMTextbox;
        }

        public TextBox returnActualPowerTextBox()
        {
            return actualPowerTextBox;
        }

        public void StopThread()
        {
            thread.Abort();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && RPMTextbox.Focused)
            {
                e.Handled = true;
                actualPowerTextBox.Text = "test";
                chatInputTextBox.Select();
            }
            if (e.KeyCode == Keys.Enter && chatInputTextBox.Focused)
            {
                e.Handled = true;
                chatInputTextBox.Select();
                string chatText = chatInputTextBox.Text;
                if (firstTime && !(chatText.Length <= 0))
                {
                    chatTextBox.Text = chatText;
                    firstTime = false;
                }
                else if (!(chatText.Length <= 0))
                {
                    chatTextBox.Text += Environment.NewLine + chatText;
                }
                chatInputTextBox.Text = "";
            }
        }
    }
}
