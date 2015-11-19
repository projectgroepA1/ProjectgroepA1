using System;
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
        public bool NameSetFlag;

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
            return setUserLabel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void SessionsHistoryButton_Click(object sender, EventArgs e)
        {
            new SessionsChooser(this, connection, form).Show();
        }

        private void PowerFormButton_Click(object sender, EventArgs e)
        {
            new Powerform(connection,this).Show();
        }

        private void UsernameButton_Click(object sender, EventArgs e)
        {
            if (userNameTB.Text == "")
            {
                MessageBox.Show("You must enter a name first!");
            }
            else if (userNameTB.Text == "monitor")
            {
                MessageBox.Show("That is not permitted!");
            }
            else
            {
                NameSetFlag = true;
                CurrentUser.Text = userNameTB.Text;
                userNameTB.Clear();
                connection.writePacket(new NamePacket(CurrentUser.Text, id.Id));
            }
        }
    }
}
