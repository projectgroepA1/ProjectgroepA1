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
using NetLib;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Connection connection;
        private bool firstTime;
        private Login login;
        private Thread t;
        private Measurement measurement;

        public Form1(TcpClient client, NetworkStream stream,Login login)
        {
            InitializeComponent();
            this.client = client;
            this.stream = stream;
            connection = new Connection(this);
            chatInputTextBox.Select();
            this.KeyPreview = true;
            t = new Thread(() => connection.Run());
            t.Start();
            firstTime = true;
            this.login = login;
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
            login.ClearBoxes();
        }

        private void pulseTextBox_TextChanged(object sender, EventArgs e)
        {
            measurement.pulse = pulseTextBox.Text;
        }

        private void textDistance_TextChanged(object sender, EventArgs e)
        {
            measurement.distance = textDistance.Text;
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
