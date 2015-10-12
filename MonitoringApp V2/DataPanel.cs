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
        private bool firstTime;
        private Form1 form;

        public DataPanel(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            chatInputTextBox.Select();
            firstTime = true;
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
    }
}
