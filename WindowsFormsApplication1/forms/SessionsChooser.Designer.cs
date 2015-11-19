namespace ClientApp.forms
{
    partial class SessionsChooser
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
            this.box = new System.Windows.Forms.ListBox();
            this.session_chooser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Location = new System.Drawing.Point(6, 6);
            this.box.Margin = new System.Windows.Forms.Padding(2);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(189, 212);
            this.box.TabIndex = 1;
            // 
            // session_chooser
            // 
            this.session_chooser.Location = new System.Drawing.Point(199, 92);
            this.session_chooser.Margin = new System.Windows.Forms.Padding(2);
            this.session_chooser.Name = "session_chooser";
            this.session_chooser.Size = new System.Drawing.Size(66, 32);
            this.session_chooser.TabIndex = 2;
            this.session_chooser.Text = "choose session";
            this.session_chooser.UseVisualStyleBackColor = true;
            this.session_chooser.Click += new System.EventHandler(this.session_chooser_Click);
            // 
            // SessionsChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 231);
            this.Controls.Add(this.session_chooser);
            this.Controls.Add(this.box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SessionsChooser";
            this.Text = "SessionsChooser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox box;
        private System.Windows.Forms.Button session_chooser;
    }
}