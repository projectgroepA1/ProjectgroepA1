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
        private Connection connection;
        private bool firstTime;
        private Login login;
        private Thread t;

        public Form1(TcpClient client,Login login)
        {
            InitializeComponent();
            this.client = client;
            connection = new Connection(this);
            chatInputTextBox.Select();
            this.KeyPreview = true;
            t = new Thread(() => connection.Run());
            t.Start();
            firstTime = true;
            this.login = login;

            Thread thread = new Thread(new ThreadStart(UpdateBox));
            thread.Start();

        }

        private void UpdateBox()
        {

            while (true)
            {
                MethodInvoker mi1 = delegate () 
                {

                    this.chart1.Series["RPM"].Points.AddXY(Double.Parse(this.timeTextbox.Text), this.RPMTextbox);

                };
                this.Invoke(mi1);
                Thread.Sleep(1000);
            }

        }

        public TextBox ReturnRPM()
        {
            return RPMTextbox;
        }

        public TextBox returnActualPowerTextBox()
        {
            return actualPowerTextBox;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && RPMTextbox.Focused)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
                actualPowerTextBox.Text = "test";
            }
            if (e.KeyCode == Keys.Enter && chatInputTextBox.Focused)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
                sendButton.PerformClick();
            }
            chatInputTextBox.Select();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string chatText = chatInputTextBox.Text;
            string currentText = chatTextBox.Text;
            if (firstTime)
            {
                chatTextBox.Text = chatText;
                firstTime = false;
            }
            else if (!(chatText.Length == 0))
            {
                chatTextBox.Text = currentText + Environment.NewLine + chatText;
            }
            chatInputTextBox.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
            login.Show();
            login.Init();
        }
    }
}
