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
using NetLib;
using NetLib.sessionpackets;
using NetLib.sessionpackets.sessions_data;

namespace MonitoringApp_V2
{
    public partial class SessionsChooser : Form
    {

        public SessionsChooser(DataPanel panel, Connection connection, Form1 form1)
        {
            //send request for the requests
            connection.writePacket(new PacketRequestSessions() { id = panel.id.Id, username = "monitor" });

            while (Connection.Sessions == null)
            {

            }
            InitializeComponent();
            //sessies
            Connection.Sessions.ForEach(session =>
            {
                this.box.Items.Add(session);
            });
        }

        private void session_chooser_Click(object sender, EventArgs e)
        {
            if (this.box.SelectedItem != null)
            {
                Session session = (Session)this.box.SelectedItem;

                //open new form
                HistoryView view = new HistoryView(session.data);
                view.ShowDialog(this);
            }
        }
    }
}
