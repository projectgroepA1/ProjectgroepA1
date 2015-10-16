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
            this.SuspendLayout();
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(104, 76);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(132, 22);
            this.timeTextBox.TabIndex = 0;
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.Location = new System.Drawing.Point(104, 135);
            this.PowerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.Size = new System.Drawing.Size(132, 22);
            this.PowerTextBox.TabIndex = 1;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(104, 196);
            this.distanceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(132, 22);
            this.distanceTextBox.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(117, 245);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(100, 28);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(151, 57);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 17);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time";
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(143, 114);
            this.PowerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(47, 17);
            this.PowerLabel.TabIndex = 5;
            this.PowerLabel.Text = "Power";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(139, 176);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(63, 17);
            this.distanceLabel.TabIndex = 6;
            this.distanceLabel.Text = "Distance";
            // 
            // NewSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 324);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.PowerTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}