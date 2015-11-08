namespace MonitoringApp_V2
{
    partial class Powerform
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
            this.PowerTB = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PowerTB
            // 
            this.PowerTB.Location = new System.Drawing.Point(29, 22);
            this.PowerTB.Name = "PowerTB";
            this.PowerTB.Size = new System.Drawing.Size(100, 20);
            this.PowerTB.TabIndex = 0;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(42, 48);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 23);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // Powerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 83);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.PowerTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Powerform";
            this.Text = "Power";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PowerTB;
        private System.Windows.Forms.Button SetButton;
    }
}