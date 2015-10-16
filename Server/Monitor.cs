using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetLib;

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
            
        }

        public override void sendMeasurement(Measurement measurement)
        {
            formatter.Serialize(Stream,measurement);
        }
    }
}
