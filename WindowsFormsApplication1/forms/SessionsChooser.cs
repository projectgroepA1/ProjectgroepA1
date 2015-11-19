using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.networking;
using NetLib;
using NetLib.sessionpackets;
using NetLib.sessionpackets.sessions_data;

namespace ClientApp.forms
{
    public partial class SessionsChooser : Form
    {
        public SessionsChooser(Client client)
        {
            //send request for the requests
            client.serverConnection.WritePacket(new PacketRequestSessions() {id = client.id, username = Login.UserName});
            while (ServerConnection.Sessions == null)
            {
                
            }
            Thread.Sleep(700);
            InitializeComponent();
            //sessies
            ServerConnection.Sessions.ForEach(session =>
            {
                this.box.Items.Add(session);
            });
        }

        private void session_chooser_Click(object sender, EventArgs e)
        {
            if (this.box.SelectedItem != null)
            {
                Session session = (Session) this.box.SelectedItem;

                //open new form
                HistoryView view = new HistoryView(session.data);
                view.ShowDialog(this);
            }
        }
    }
}
