using NetLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace MonitoringApp_V2
{
    public partial class FileLoader : Form
    {
        private Form1 form;
        private Connection connection;
        public FileLoader(Form1 form, Connection connection)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.form = form;
            this.connection = connection;
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && ReturnTextBox().Focused)
            {
                ReturnTextBox().Select();
                string chatText = ReturnTextBox().Text;
                connection.writePacket(new PacketLoadfile(chatText));
                textBox.Clear();
                this.Hide();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public TextBox ReturnTextBox()
        {
            return textBox;
        }

    }
}
