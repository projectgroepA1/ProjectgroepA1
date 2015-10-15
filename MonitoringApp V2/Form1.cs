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
using WindowsFormsApplication2;

namespace MonitoringApp_V2
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public NetworkStream stream { get; }
        private Login login;
        public List<DataPanel> panels { get; }
        public Thread thread { get; }
        private Connection connection;

        public Form1(TcpClient client, NetworkStream stream, Login login)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.client = client;
            this.stream = stream;
            this.login = login;
            panels = new List<DataPanel>();
            connection = new Connection(this);
            thread = new Thread(() => connection.Run());
            thread.Start();
            KeyPreview = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            foreach (DataPanel panel in panels)
            {
                if (e.KeyCode == Keys.Enter && panel.ReturnRPM().Focused)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                    panel.ReturnActualPowerTextBox().Text = "test";
                    panel.ReturnChatInputTextBox().Select();
                }
                if (e.KeyCode == Keys.Enter && panel.ReturnChatInputTextBox().Focused)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                    panel.ReturnChatInputTextBox().Select();
                    string chatText = panel.ReturnChatInputTextBox().Text;
                    if (panel.ReturnFirstTime() && !(chatText.Length <= 0))
                    {
                        panel.ReturnChatTextBox().Text = chatText;
                        panel.changeFirstTime(false);
                    }
                    else if (!(chatText.Length <= 0))
                    {
                        panel.ReturnChatTextBox().Text += Environment.NewLine + chatText;
                    }
                    panel.ReturnChatInputTextBox().Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataPanel panel = new DataPanel(this);
            panels.Add(panel);
            flowLayoutPanel.Controls.Add(panel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
            login.Show();
            login.ClearBoxes();
        }
    }
}
