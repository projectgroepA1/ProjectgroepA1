namespace MonitoringApp_V2
{
    partial class NewSession
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
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.radioButton_Time = new System.Windows.Forms.RadioButton();
            this.radioButton_Distance = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(13, 72);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 0;
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.Location = new System.Drawing.Point(67, 111);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.Size = new System.Drawing.Size(100, 20);
            this.PowerTextBox.TabIndex = 1;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(120, 72);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(77, 139);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Start";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(46, 56);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time";
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(90, 95);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(62, 13);
            this.PowerLabel.TabIndex = 5;
            this.PowerLabel.Text = "Start Power";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(148, 56);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(49, 13);
            this.distanceLabel.TabIndex = 6;
            this.distanceLabel.Text = "Distance";
            // 
            // radioButton_Time
            // 
            this.radioButton_Time.AutoSize = true;
            this.radioButton_Time.Location = new System.Drawing.Point(13, 25);
            this.radioButton_Time.Name = "radioButton_Time";
            this.radioButton_Time.Size = new System.Drawing.Size(88, 17);
            this.radioButton_Time.TabIndex = 7;
            this.radioButton_Time.TabStop = true;
            this.radioButton_Time.Text = "Time Session";
            this.radioButton_Time.UseVisualStyleBackColor = true;
            this.radioButton_Time.CheckedChanged += new System.EventHandler(this.radioButton_Time_CheckedChanged);
            // 
            // radioButton_Distance
            // 
            this.radioButton_Distance.AutoSize = true;
            this.radioButton_Distance.Location = new System.Drawing.Point(120, 25);
            this.radioButton_Distance.Name = "radioButton_Distance";
            this.radioButton_Distance.Size = new System.Drawing.Size(107, 17);
            this.radioButton_Distance.TabIndex = 8;
            this.radioButton_Distance.TabStop = true;
            this.radioButton_Distance.Text = "Distance Session";
            this.radioButton_Distance.UseVisualStyleBackColor = true;
            this.radioButton_Distance.CheckedChanged += new System.EventHandler(this.radioButton_Distance_CheckedChanged);
            // 
            // NewSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 165);
            this.Controls.Add(this.radioButton_Distance);
            this.Controls.Add(this.radioButton_Time);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.PowerTextBox);
            this.Controls.Add(this.timeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "NewSession";
            this.Text = "New Session";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox PowerTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.RadioButton radioButton_Time;
        private System.Windows.Forms.RadioButton radioButton_Distance;
    }
}