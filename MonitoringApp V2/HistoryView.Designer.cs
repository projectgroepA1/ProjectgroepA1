namespace MonitoringApp_V2
{
    partial class HistoryView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Rpm_checkBox = new System.Windows.Forms.CheckBox();
            this.Speed_checkBox = new System.Windows.Forms.CheckBox();
            this.Distance_checkBox = new System.Windows.Forms.CheckBox();
            this.Power_checkBox = new System.Windows.Forms.CheckBox();
            this.Energy_checkBox = new System.Windows.Forms.CheckBox();
            this.ActualPower_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pulse_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(124, 23);
            this.chart1.Name = "chart1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.Name = "Pulse";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.Name = "Rpm";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.Name = "Speed";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.Name = "Distance";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Legend = "Legend1";
            series19.Name = "Power";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Legend = "Legend1";
            series20.Name = "Energy";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.Name = "Actual power";
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Series.Add(series21);
            this.chart1.Size = new System.Drawing.Size(547, 320);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // Rpm_checkBox
            // 
            this.Rpm_checkBox.AutoSize = true;
            this.Rpm_checkBox.Location = new System.Drawing.Point(11, 101);
            this.Rpm_checkBox.Name = "Rpm_checkBox";
            this.Rpm_checkBox.Size = new System.Drawing.Size(48, 17);
            this.Rpm_checkBox.TabIndex = 18;
            this.Rpm_checkBox.Text = "Rpm";
            this.Rpm_checkBox.UseVisualStyleBackColor = true;
            this.Rpm_checkBox.CheckedChanged += new System.EventHandler(this.Rpm_checkBox_CheckedChanged);
            // 
            // Speed_checkBox
            // 
            this.Speed_checkBox.AutoSize = true;
            this.Speed_checkBox.Location = new System.Drawing.Point(10, 140);
            this.Speed_checkBox.Name = "Speed_checkBox";
            this.Speed_checkBox.Size = new System.Drawing.Size(57, 17);
            this.Speed_checkBox.TabIndex = 19;
            this.Speed_checkBox.Text = "Speed";
            this.Speed_checkBox.UseVisualStyleBackColor = true;
            this.Speed_checkBox.CheckedChanged += new System.EventHandler(this.Speed_checkBox_CheckedChanged);
            // 
            // Distance_checkBox
            // 
            this.Distance_checkBox.AutoSize = true;
            this.Distance_checkBox.Location = new System.Drawing.Point(10, 186);
            this.Distance_checkBox.Name = "Distance_checkBox";
            this.Distance_checkBox.Size = new System.Drawing.Size(68, 17);
            this.Distance_checkBox.TabIndex = 20;
            this.Distance_checkBox.Text = "Distance";
            this.Distance_checkBox.UseVisualStyleBackColor = true;
            this.Distance_checkBox.CheckedChanged += new System.EventHandler(this.Distance_checkBox4_CheckedChanged);
            // 
            // Power_checkBox
            // 
            this.Power_checkBox.AutoSize = true;
            this.Power_checkBox.Location = new System.Drawing.Point(11, 230);
            this.Power_checkBox.Name = "Power_checkBox";
            this.Power_checkBox.Size = new System.Drawing.Size(56, 17);
            this.Power_checkBox.TabIndex = 21;
            this.Power_checkBox.Text = "Power";
            this.Power_checkBox.UseVisualStyleBackColor = true;
            this.Power_checkBox.CheckedChanged += new System.EventHandler(this.Power_checkBox5_CheckedChanged);
            // 
            // Energy_checkBox
            // 
            this.Energy_checkBox.AutoSize = true;
            this.Energy_checkBox.Location = new System.Drawing.Point(10, 272);
            this.Energy_checkBox.Name = "Energy_checkBox";
            this.Energy_checkBox.Size = new System.Drawing.Size(59, 17);
            this.Energy_checkBox.TabIndex = 22;
            this.Energy_checkBox.Text = "Energy";
            this.Energy_checkBox.UseVisualStyleBackColor = true;
            this.Energy_checkBox.CheckedChanged += new System.EventHandler(this.Energy_checkBox6_CheckedChanged);
            // 
            // ActualPower_checkBox
            // 
            this.ActualPower_checkBox.AutoSize = true;
            this.ActualPower_checkBox.Location = new System.Drawing.Point(10, 309);
            this.ActualPower_checkBox.Name = "ActualPower_checkBox";
            this.ActualPower_checkBox.Size = new System.Drawing.Size(88, 17);
            this.ActualPower_checkBox.TabIndex = 24;
            this.ActualPower_checkBox.Text = "Actual power";
            this.ActualPower_checkBox.UseVisualStyleBackColor = true;
            this.ActualPower_checkBox.CheckedChanged += new System.EventHandler(this.ActualPower_checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "View";
            // 
            // Pulse_checkBox
            // 
            this.Pulse_checkBox.AutoSize = true;
            this.Pulse_checkBox.Location = new System.Drawing.Point(11, 64);
            this.Pulse_checkBox.Name = "Pulse_checkBox";
            this.Pulse_checkBox.Size = new System.Drawing.Size(52, 17);
            this.Pulse_checkBox.TabIndex = 17;
            this.Pulse_checkBox.Text = "Pulse";
            this.Pulse_checkBox.UseVisualStyleBackColor = true;
            this.Pulse_checkBox.CheckedChanged += new System.EventHandler(this.Pulse_checkBox_CheckedChanged);
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActualPower_checkBox);
            this.Controls.Add(this.Energy_checkBox);
            this.Controls.Add(this.Power_checkBox);
            this.Controls.Add(this.Distance_checkBox);
            this.Controls.Add(this.Speed_checkBox);
            this.Controls.Add(this.Rpm_checkBox);
            this.Controls.Add(this.Pulse_checkBox);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HistoryView";
            this.Text = "HistoryView";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox Rpm_checkBox;
        private System.Windows.Forms.CheckBox Speed_checkBox;
        private System.Windows.Forms.CheckBox Distance_checkBox;
        private System.Windows.Forms.CheckBox Power_checkBox;
        private System.Windows.Forms.CheckBox Energy_checkBox;
        private System.Windows.Forms.CheckBox ActualPower_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Pulse_checkBox;
    }
}