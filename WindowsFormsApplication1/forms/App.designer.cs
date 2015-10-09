
﻿using System.Windows.Forms;

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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.actualpower = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "RPM";
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
            this.label6.Location = new System.Drawing.Point(10, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Actual Power";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(10, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pulse";
            // 
            // pulse
            // 
            this.pulse.Location = new System.Drawing.Point(102, 62);
            this.pulse.Name = "pulse";
            this.pulse.ReadOnly = true;
            this.pulse.Size = new System.Drawing.Size(100, 20);
            this.pulse.TabIndex = 7;
            // 
            // rpm
            // 
            this.rpm.Location = new System.Drawing.Point(102, 101);
            this.rpm.Name = "rpm";
            this.rpm.ReadOnly = true;
            this.rpm.Size = new System.Drawing.Size(100, 20);
            this.rpm.TabIndex = 8;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(102, 139);
            this.speed.Name = "speed";
            this.speed.ReadOnly = true;
            this.speed.Size = new System.Drawing.Size(100, 20);
            this.speed.TabIndex = 9;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(102, 176);
            this.distance.Name = "distance";
            this.distance.ReadOnly = true;
            this.distance.Size = new System.Drawing.Size(100, 20);
            this.distance.TabIndex = 10;
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(102, 214);
            this.power.Name = "power";
            this.power.ReadOnly = true;
            this.power.Size = new System.Drawing.Size(100, 20);
            this.power.TabIndex = 11;
            // 
            // energy
            // 
            this.energy.Location = new System.Drawing.Point(102, 253);
            this.energy.Name = "energy";
            this.energy.ReadOnly = true;
            this.energy.Size = new System.Drawing.Size(100, 20);
            this.energy.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(352, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comments from Medical Supervisor";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(11, 395);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(308, 70);
            this.textBox7.TabIndex = 15;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(350, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 86);
            this.button1.TabIndex = 16;
            this.button1.Text = "Request Help";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(232, 54);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(363, 300);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(11, 469);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(308, 20);
            this.textBox8.TabIndex = 18;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.textBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Distance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Speed";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(102, 287);
            this.time.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 21;
            // 
            // actualpower
            // 
            this.actualpower.Location = new System.Drawing.Point(102, 322);
            this.actualpower.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.actualpower.Name = "actualpower";
            this.actualpower.ReadOnly = true;
            this.actualpower.Size = new System.Drawing.Size(100, 20);
            this.actualpower.TabIndex = 22;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(603, 454);
            this.Controls.Add(this.actualpower);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox actualpower;
    }
}
