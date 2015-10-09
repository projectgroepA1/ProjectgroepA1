using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class DataPanels : Panel
    {
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label RPMLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label energyLabel;
        private System.Windows.Forms.Label actualPowerLabel;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox actualPowerTextBox;
        private System.Windows.Forms.TextBox energyTextBox;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.TextBox timeTextbox;
        private System.Windows.Forms.TextBox RPMTextbox;
        private System.Windows.Forms.TextBox chatTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox chatInputTextBox;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Client1");
            this.chatInputTextBox = new System.Windows.Forms.TextBox();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.actualPowerTextBox = new System.Windows.Forms.TextBox();
            this.energyTextBox = new System.Windows.Forms.TextBox();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.timeTextbox = new System.Windows.Forms.TextBox();
            this.RPMTextbox = new System.Windows.Forms.TextBox();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.actualPowerLabel = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.RPMLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chatInputTextBox
            // 
            this.chatInputTextBox.Location = new System.Drawing.Point(223, 266);
            this.chatInputTextBox.Name = "chatInputTextBox";
            this.chatInputTextBox.Size = new System.Drawing.Size(314, 20);
            this.chatInputTextBox.TabIndex = 21;
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(223, 195);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.chatTextBox.Size = new System.Drawing.Size(314, 65);
            this.chatTextBox.TabIndex = 18;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(223, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(314, 166);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Location = new System.Drawing.Point(121, 225);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.ReadOnly = true;
            this.pulseTextBox.Size = new System.Drawing.Size(63, 20);
            this.pulseTextBox.TabIndex = 16;
            // 
            // actualPowerTextBox
            // 
            this.actualPowerTextBox.Location = new System.Drawing.Point(121, 198);
            this.actualPowerTextBox.Name = "actualPowerTextBox";
            this.actualPowerTextBox.ReadOnly = true;
            this.actualPowerTextBox.Size = new System.Drawing.Size(63, 20);
            this.actualPowerTextBox.TabIndex = 15;
            // 
            // energyTextBox
            // 
            this.energyTextBox.Location = new System.Drawing.Point(121, 169);
            this.energyTextBox.Name = "energyTextBox";
            this.energyTextBox.ReadOnly = true;
            this.energyTextBox.Size = new System.Drawing.Size(63, 20);
            this.energyTextBox.TabIndex = 14;
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(121, 138);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.ReadOnly = true;
            this.powerTextBox.Size = new System.Drawing.Size(63, 20);
            this.powerTextBox.TabIndex = 13;
            // 
            // timeTextbox
            // 
            this.timeTextbox.Location = new System.Drawing.Point(121, 106);
            this.timeTextbox.Name = "timeTextbox";
            this.timeTextbox.ReadOnly = true;
            this.timeTextbox.Size = new System.Drawing.Size(63, 20);
            this.timeTextbox.TabIndex = 12;
            // 
            // RPMTextbox
            // 
            this.RPMTextbox.Location = new System.Drawing.Point(121, 74);
            this.RPMTextbox.Name = "RPMTextbox";
            this.RPMTextbox.Size = new System.Drawing.Size(63, 20);
            this.RPMTextbox.TabIndex = 11;
            // 
            // pulseLabel
            // 
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pulseLabel.Location = new System.Drawing.Point(13, 227);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(43, 17);
            this.pulseLabel.TabIndex = 10;
            this.pulseLabel.Text = "Pulse";
            // 
            // actualPowerLabel
            // 
            this.actualPowerLabel.AutoSize = true;
            this.actualPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.actualPowerLabel.Location = new System.Drawing.Point(13, 200);
            this.actualPowerLabel.Name = "actualPowerLabel";
            this.actualPowerLabel.Size = new System.Drawing.Size(90, 17);
            this.actualPowerLabel.TabIndex = 9;
            this.actualPowerLabel.Text = "Actual Power";
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.energyLabel.Location = new System.Drawing.Point(13, 169);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(53, 17);
            this.energyLabel.TabIndex = 8;
            this.energyLabel.Text = "Energy";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.powerLabel.Location = new System.Drawing.Point(13, 140);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(47, 17);
            this.powerLabel.TabIndex = 7;
            this.powerLabel.Text = "Power";
            // 
            // RPMLabel
            // 
            this.RPMLabel.AutoSize = true;
            this.RPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RPMLabel.Location = new System.Drawing.Point(13, 74);
            this.RPMLabel.Name = "RPMLabel";
            this.RPMLabel.Size = new System.Drawing.Size(38, 17);
            this.RPMLabel.TabIndex = 6;
            this.RPMLabel.Text = "RPM";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.timeLabel.Location = new System.Drawing.Point(13, 106);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 17);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client1";
        }
    }
}
