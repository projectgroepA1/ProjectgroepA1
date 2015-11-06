using System;
using System.Windows.Forms;
using WindowsFormsApplication2;
using NetLib;

namespace MonitoringApp_V2
{
    public partial class Powerform : Form
    {
        private Connection connection;
        private DataPanel panel;

        public Powerform(Connection connection,DataPanel panel)
        {
            InitializeComponent();
            this.connection = connection;
            this.panel = panel;
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            PacketBicycleCommand pw = new PacketBicycleCommand($"PW {PowerTB.Text}", panel.id.Id);
            connection.writePacket(pw);
            Hide();
        }
    }
}
