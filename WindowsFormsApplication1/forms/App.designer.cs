
using System.Windows.Forms;

namespace ClientApp
{
    partial class Client : Form

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pulse = new System.Windows.Forms.TextBox();
            this.rpm = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.distance = new System.Windows.Forms.TextBox();
            this.power = new System.Windows.Forms.TextBox();
            this.energy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Chatbox = new System.Windows.Forms.TextBox();
            this.Grafiek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Sendbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.actualpower = new System.Windows.Forms.TextBox();
            this.sessions_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grafiek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rpm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(10, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Power";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(10, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Energy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(10, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Actual Power";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(9, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pulse";
            // 
            // pulse
            // 
            this.pulse.Location = new System.Drawing.Point(118, 87);
            this.pulse.Name = "pulse";
            this.pulse.ReadOnly = true;
            this.pulse.Size = new System.Drawing.Size(100, 20);
            this.pulse.TabIndex = 7;
            // 
            // rpm
            // 
            this.rpm.Location = new System.Drawing.Point(118, 116);
            this.rpm.Name = "rpm";
            this.rpm.ReadOnly = true;
            this.rpm.Size = new System.Drawing.Size(100, 20);
            this.rpm.TabIndex = 8;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(118, 148);
            this.speed.Name = "speed";
            this.speed.ReadOnly = true;
            this.speed.Size = new System.Drawing.Size(100, 20);
            this.speed.TabIndex = 9;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(118, 182);
            this.distance.Name = "distance";
            this.distance.ReadOnly = true;
            this.distance.Size = new System.Drawing.Size(100, 20);
            this.distance.TabIndex = 10;
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(118, 217);
            this.power.Name = "power";
            this.power.ReadOnly = true;
            this.power.Size = new System.Drawing.Size(100, 20);
            this.power.TabIndex = 11;
            // 
            // energy
            // 
            this.energy.Location = new System.Drawing.Point(118, 251);
            this.energy.Name = "energy";
            this.energy.ReadOnly = true;
            this.energy.Size = new System.Drawing.Size(100, 20);
            this.energy.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(352, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comments from Medical Supervisor";
            // 
            // Chatbox
            // 
            this.Chatbox.Location = new System.Drawing.Point(102, 384);
            this.Chatbox.Multiline = true;
            this.Chatbox.Name = "Chatbox";
            this.Chatbox.ReadOnly = true;
            this.Chatbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Chatbox.Size = new System.Drawing.Size(394, 81);
            this.Chatbox.TabIndex = 15;
            // 
            // Grafiek
            // 
            chartArea1.Name = "ChartArea1";
            this.Grafiek.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafiek.Legends.Add(legend1);
            this.Grafiek.Location = new System.Drawing.Point(232, 54);
            this.Grafiek.Name = "Grafiek";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Pulse";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Rpm";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Speed";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Distance";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Power";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Energy";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "ActualPower";
            this.Grafiek.Series.Add(series1);
            this.Grafiek.Series.Add(series2);
            this.Grafiek.Series.Add(series3);
            this.Grafiek.Series.Add(series4);
            this.Grafiek.Series.Add(series5);
            this.Grafiek.Series.Add(series6);
            this.Grafiek.Series.Add(series7);
            this.Grafiek.Size = new System.Drawing.Size(363, 300);
            this.Grafiek.TabIndex = 17;
            this.Grafiek.Text = "Grafiek";
            // 
            // Sendbox
            // 
            this.Sendbox.Location = new System.Drawing.Point(102, 471);
            this.Sendbox.Margin = new System.Windows.Forms.Padding(2);
            this.Sendbox.Name = "Sendbox";
            this.Sendbox.Size = new System.Drawing.Size(394, 20);
            this.Sendbox.TabIndex = 18;
            this.Sendbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(9, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Distance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(9, 147);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Speed";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(118, 286);
            this.time.Margin = new System.Windows.Forms.Padding(2);
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 21;
            // 
            // actualpower
            // 
            this.actualpower.Location = new System.Drawing.Point(118, 323);
            this.actualpower.Margin = new System.Windows.Forms.Padding(2);
            this.actualpower.Name = "actualpower";
            this.actualpower.ReadOnly = true;
            this.actualpower.Size = new System.Drawing.Size(100, 20);
            this.actualpower.TabIndex = 22;
            // 
            // sessions_button
            // 
            this.sessions_button.Location = new System.Drawing.Point(505, 14);
            this.sessions_button.Margin = new System.Windows.Forms.Padding(2);
            this.sessions_button.Name = "sessions_button";
            this.sessions_button.Size = new System.Drawing.Size(90, 32);
            this.sessions_button.TabIndex = 23;
            this.sessions_button.Text = "Session History";
            this.sessions_button.UseVisualStyleBackColor = true;
            this.sessions_button.Click += new System.EventHandler(this.sessions_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "(x100m)";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.Location = new System.Drawing.Point(115, 54);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(0, 17);
            this.ClientName.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(9, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "User";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(603, 498);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sessions_button);
            this.Controls.Add(this.actualpower);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Sendbox);
            this.Controls.Add(this.Grafiek);
            this.Controls.Add(this.Chatbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.energy);
            this.Controls.Add(this.power);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.rpm);
            this.Controls.Add(this.pulse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grafiek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pulse;
        private System.Windows.Forms.TextBox rpm;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox power;
        private System.Windows.Forms.TextBox energy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Chatbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafiek;
        private System.Windows.Forms.TextBox Sendbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox actualpower;
        private Button sessions_button;
        private Label label11;
        private Label ClientName;
        private Label label12;
    }
}

