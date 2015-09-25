namespace WindowsFormsApplication2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Client1");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.helpPictureBox = new System.Windows.Forms.PictureBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.actualPowerTextBox = new System.Windows.Forms.TextBox();
            this.energyTextBox = new System.Windows.Forms.TextBox();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.RPMTextBox = new System.Windows.Forms.TextBox();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.actualPowerLabel = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.RPMLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1379, 670);
            this.splitContainer1.SplitterDistance = 1126;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1126, 670);
            this.splitContainer2.SplitterDistance = 558;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.helpPictureBox);
            this.splitContainer3.Panel1.Controls.Add(this.sendButton);
            this.splitContainer3.Panel1.Controls.Add(this.chatBox);
            this.splitContainer3.Panel1.Controls.Add(this.chart);
            this.splitContainer3.Panel1.Controls.Add(this.pulseTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.actualPowerTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.energyTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.powerTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.timeTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.RPMTextBox);
            this.splitContainer3.Panel1.Controls.Add(this.pulseLabel);
            this.splitContainer3.Panel1.Controls.Add(this.actualPowerLabel);
            this.splitContainer3.Panel1.Controls.Add(this.energyLabel);
            this.splitContainer3.Panel1.Controls.Add(this.powerLabel);
            this.splitContainer3.Panel1.Controls.Add(this.RPMLabel);
            this.splitContainer3.Panel1.Controls.Add(this.timeLabel);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Size = new System.Drawing.Size(558, 670);
            this.splitContainer3.SplitterDistance = 328;
            this.splitContainer3.TabIndex = 0;
            // 
            // helpPictureBox
            // 
            this.helpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("helpPictureBox.Image")));
            this.helpPictureBox.Location = new System.Drawing.Point(121, 251);
            this.helpPictureBox.Name = "helpPictureBox";
            this.helpPictureBox.Size = new System.Drawing.Size(72, 65);
            this.helpPictureBox.TabIndex = 20;
            this.helpPictureBox.TabStop = false;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(343, 293);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 19;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(223, 222);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(314, 65);
            this.chatBox.TabIndex = 18;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(223, 50);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(314, 166);
            this.chart.TabIndex = 17;
            this.chart.Text = "chart1";
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
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(121, 106);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(63, 20);
            this.timeTextBox.TabIndex = 12;
            // 
            // RPMTextBox
            // 
            this.RPMTextBox.Location = new System.Drawing.Point(121, 74);
            this.RPMTextBox.Name = "RPMTextBox";
            this.RPMTextBox.ReadOnly = true;
            this.RPMTextBox.Size = new System.Drawing.Size(63, 20);
            this.RPMTextBox.TabIndex = 11;
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
            this.RPMLabel.Click += new System.EventHandler(this.label3_Click);
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
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer4.Size = new System.Drawing.Size(564, 670);
            this.splitContainer4.SplitterDistance = 328;
            this.splitContainer4.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 664);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 670);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Monitoring";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
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
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox RPMTextBox;
        private System.Windows.Forms.PictureBox helpPictureBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

