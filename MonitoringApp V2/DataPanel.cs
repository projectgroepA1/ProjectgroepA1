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
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApplication2;
using NetLib;

namespace MonitoringApp_V2
{
    public partial class DataPanel : UserControl
    {
        private bool firstTime;
        public Form1 form { get; }
        private Connection connection;
        public Identifier id { get; }

        public DataPanel(Form1 form, Connection connection, Identifier id)
        {
            InitializeComponent();
            this.form = form;
            chatInputTextBox.Select();
            firstTime = true;
            this.connection = connection;
            this.id = id;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && ReturnActualPowerTextBox().Focused)
            {
                ReturnChatInputTextBox().Select();
                RPMTextbox.Text = "text";
            }
            if (keyData == Keys.Enter && ReturnChatInputTextBox().Focused)
            {
                ReturnChatInputTextBox().Select();
                string chatText = ReturnChatInputTextBox().Text;
                changeChatBoxTextSelf(chatText);
                PacketChat chat = new PacketChat(chatText, id.Username, "client", id.Id);
                connection.writePacket(chat);
                chatInputTextBox.Clear();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void changeChatBoxText(string chatText)
        {
            chatTextBox.AppendText("[client] " + chatText);
        }

        public void changeChatBoxTextSelf(string chatText)
        {
            chatTextBox.AppendText("[doctor] " + chatText + Environment.NewLine);
        }

        public TextBox ReturnChatBoxText()
        {
            return chatTextBox;
        }

        public TextBox ReturnRPM()
        {
            return RPMTextbox;
        }

        public TextBox ReturnTimeTextBox()
        {
            return timeTextbox;
        }

        public TextBox ReturnPowerTextBox()
        {
            return powerTextBox;
        }

        public TextBox ReturnEnergyTextBox()
        {
            return energyTextBox;
        }

        public TextBox ReturnActualPowerTextBox()
        {
            return actualPowerTextBox;
        }

        public TextBox ReturnPulseTextBox()
        {
            return pulseTextBox;
        }

        public TextBox ReturnChatInputTextBox()
        {
            return chatInputTextBox;
        }

        public TextBox ReturnChatTextBox()
        {
            return chatTextBox;
        }

        public bool ReturnFirstTime()
        {
            return firstTime;
        }

        public void changeFirstTime(bool first)
        {
            firstTime = first;
        }

        public Chart returnChart()
        {
            return chart1;
        }

        public TextBox ReturnDistanceTextBox()
        {
            return distanceTextBox;
        }

        public Label ReturnUserNameLabel()
        {
            return userLabel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newSessionButton_Click(object sender, EventArgs e)
        {
            new NewSession(this, connection).Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public TextBox ReturnSpeedTextBox()
        {
           return speedTextBox; 
        }

        private void userLabel_Click(object sender, EventArgs e)
        {
        }

        private void ClientName_Click(object sender, EventArgs e)
        {
            this.ClientName.Text = id.Username;
        }
    }
}
