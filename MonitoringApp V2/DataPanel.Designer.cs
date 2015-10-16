namespace MonitoringApp_V2
{
    partial class DataPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPanel));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.RPMLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RPMTextbox = new System.Windows.Forms.TextBox();
            this.timeTextbox = new System.Windows.Forms.TextBox();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.energyTextBox = new System.Windows.Forms.TextBox();
            this.actualPowerTextBox = new System.Windows.Forms.TextBox();
            this.actualPowerLabel = new System.Windows.Forms.Label();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.chatInputTextBox = new System.Windows.Forms.TextBox();
            this.Distance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // RPMLabel
            // 
            this.RPMLabel.AutoSize = true;
            this.RPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RPMLabel.Location = new System.Drawing.Point(18, 26);
            this.RPMLabel.Name = "RPMLabel";
            this.RPMLabel.Size = new System.Drawing.Size(38, 17);
            this.RPMLabel.TabIndex = 7;
            this.RPMLabel.Text = "RPM";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.timeLabel.Location = new System.Drawing.Point(18, 57);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 17);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Time";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.powerLabel.Location = new System.Drawing.Point(18, 90);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(47, 17);
            this.powerLabel.TabIndex = 9;
            this.powerLabel.Text = "Power";
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.energyLabel.Location = new System.Drawing.Point(18, 126);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(53, 17);
            this.energyLabel.TabIndex = 10;
            this.energyLabel.Text = "Energy";
            // 
            // pulseLabel
            // 
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pulseLabel.Location = new System.Drawing.Point(18, 201);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(43, 17);
            this.pulseLabel.TabIndex = 11;
            this.pulseLabel.Text = "Pulse";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 65);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // RPMTextbox
            // 
            this.RPMTextbox.Location = new System.Drawing.Point(113, 26);
            this.RPMTextbox.Name = "RPMTextbox";
            this.RPMTextbox.Size = new System.Drawing.Size(63, 20);
            this.RPMTextbox.TabIndex = 22;
            // 
            // timeTextbox
            // 
            this.timeTextbox.Location = new System.Drawing.Point(113, 57);
            this.timeTextbox.Name = "timeTextbox";
            this.timeTextbox.ReadOnly = true;
            this.timeTextbox.Size = new System.Drawing.Size(63, 20);
            this.timeTextbox.TabIndex = 23;
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(113, 90);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.ReadOnly = true;
            this.powerTextBox.Size = new System.Drawing.Size(63, 20);
            this.powerTextBox.TabIndex = 24;
            // 
            // energyTextBox
            // 
            this.energyTextBox.Location = new System.Drawing.Point(113, 126);
            this.energyTextBox.Name = "energyTextBox";
            this.energyTextBox.ReadOnly = true;
            this.energyTextBox.Size = new System.Drawing.Size(63, 20);
            this.energyTextBox.TabIndex = 25;
            // 
            // actualPowerTextBox
            // 
            this.actualPowerTextBox.Location = new System.Drawing.Point(113, 162);
            this.actualPowerTextBox.Name = "actualPowerTextBox";
            this.actualPowerTextBox.ReadOnly = true;
            this.actualPowerTextBox.Size = new System.Drawing.Size(63, 20);
            this.actualPowerTextBox.TabIndex = 26;
            // 
            // actualPowerLabel
            // 
            this.actualPowerLabel.AutoSize = true;
            this.actualPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.actualPowerLabel.Location = new System.Drawing.Point(18, 162);
            this.actualPowerLabel.Name = "actualPowerLabel";
            this.actualPowerLabel.Size = new System.Drawing.Size(90, 17);
            this.actualPowerLabel.TabIndex = 27;
            this.actualPowerLabel.Text = "Actual Power";
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Location = new System.Drawing.Point(113, 198);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.ReadOnly = true;
            this.pulseTextBox.Size = new System.Drawing.Size(63, 20);
            this.pulseTextBox.TabIndex = 28;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(205, 26);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(314, 166);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(205, 211);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.chatTextBox.Size = new System.Drawing.Size(314, 65);
            this.chatTextBox.TabIndex = 30;
            // 
            // chatInputTextBox
            // 
            this.chatInputTextBox.Location = new System.Drawing.Point(205, 282);
            this.chatInputTextBox.Name = "chatInputTextBox";
            this.chatInputTextBox.Size = new System.Drawing.Size(314, 20);
            this.chatInputTextBox.TabIndex = 31;
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(0, 0);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(100, 20);
            this.Distance.TabIndex = 0;
            this.Distance.Text = "Distance";
            this.Distance.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DataPanel
            // 
            this.Controls.Add(this.chatInputTextBox);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pulseTextBox);
            this.Controls.Add(this.actualPowerLabel);
            this.Controls.Add(this.actualPowerTextBox);
            this.Controls.Add(this.energyTextBox);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.timeTextbox);
            this.Controls.Add(this.RPMTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pulseLabel);
            this.Controls.Add(this.energyLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.RPMLabel);
            this.Size = new System.Drawing.Size(539, 324);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RPMLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label energyLabel;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox RPMTextbox;
        private System.Windows.Forms.TextBox timeTextbox;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.TextBox energyTextBox;
        private System.Windows.Forms.TextBox actualPowerTextBox;
        private System.Windows.Forms.Label actualPowerLabel;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox chatTextBox;
        private System.Windows.Forms.TextBox chatInputTextBox;
        private System.Windows.Forms.TextBox Distance;
    }
}
