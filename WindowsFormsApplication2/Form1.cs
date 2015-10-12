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
        private bool firstTime;
        private Login login;
        private Thread thread;
        private List<DataPanels> panels;
        private DataPanels panel;

        public Form1(TcpClient client, NetworkStream stream,Login login)
        {
            InitializeComponent();
            this.client = client;
            this.stream = stream;
            this.login = login;
            connection = new Connection(this);
            panels = new List<DataPanels>();
            chatInputTextBox.Select();
            this.KeyPreview = true;
            thread = new Thread(() => connection.Run());
            thread.Start();

            firstTime = true;
            panel = new DataPanels();


        }

        private void UpdateBox()
        {

            //while (true)
            //{
            //    MethodInvoker mi1 = delegate () 
            //    {

            //        this.chart1.Series["RPM"].Points.AddXY(Double.Parse(this.timeTextbox.Text), this.RPMTextbox);

            //    };
            //    this.Invoke(mi1);
            //    Thread.Sleep(1000);
            //}

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
                chatInputTextBox.Select();
            }
            if (e.KeyCode == Keys.Enter && chatInputTextBox.Focused)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
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
            if (e.KeyCode == Keys.Escape)
            {
                splitContainer2.Controls.Add(panel);
                panel.Dock = DockStyle.Fill;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
            login.Show();
            login.ClearBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
