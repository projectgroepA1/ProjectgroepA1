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

        private readonly DataStorage _storage;

        public Monitor(TcpClient client, Program server, List<Client> clients) : base(client, server)
        {
            this._storage = new DataStorage();
            this._clients = clients;
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

        public override void sendNewClient(Identifier id)
        {
            sendPacket(new PacketNewClient() {Identifier = id});
        }

        public override void getMeasurements(string name)
        {
            _storage.LoadFile(name);
            sendMeasurementList();
        }

        public override void sendMeasurementList()
        {
            sendPacket(new PacketMeasurementList(_storage.measurementsList));
        }

        public override void receivePacketSession(PacketSession ps)
        {
            _server.sendPacketToClient(ps,ps.Identifier.Id);
        }
    }
}
