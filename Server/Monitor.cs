using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetLib;
using System.Windows.Forms;

namespace Server
{
    class Monitor : ServerClient
    {
        private List<Client> _clients;

        public Monitor(TcpClient client, Program server, List<Client> clients) : base(client, server)
        {
            this._clients = clients;
        }

        public override string GetName()
        {
            return "Monitor";
        }

        public override void disconnect(bool disconnect)
        {
            if (disconnect)
            {
                this.TcpClient.Close();
                
                //Console.WriteLine("Monitor closed: {0}",GetHashCode());
            }
        }

        public override void login(string username, string password)
        {
           if (username == "arjen" && password == "mourik")
            {
                sendPacket(new PacketLoginResponse() {loginOk = true});
            }
            else
            {
                sendPacket(new PacketLoginResponse() {loginOk = false});
                _server.ResetMonitor();
            }
        }

        public override void sendMeasurement(PacketMeasurement pack)
        {
            sendPacket(pack);
        }

        public override void sendNewClient(string username, int counter)
        {
            sendPacket(new PacketNewClient() {usename = username, counter = counter});
        }
    }
}
