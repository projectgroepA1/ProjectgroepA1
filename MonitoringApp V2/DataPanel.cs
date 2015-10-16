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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
