using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetLib;

namespace Server
{
    class Client : ServerClient
    {
        private readonly DataStorage _storage;
        private string _username;
        
        public Client(TcpClient tcpClient, Program server) : base(tcpClient,server)
        {
            this._storage = new DataStorage();
        }

        public override string GetName()
        {
            return "Client: " + _username;
        }

        public override void login(string username, string password)
        {
            this._username = username;
            if (username == "admin" && password == "12345")
            {
                sendPacket(new PacketLoginResponse() {loginOk = true});
            }
            else
            {
                sendPacket(new PacketLoginResponse() {loginOk = false});
            }

        }

        public override void sendMeasurement(Measurement measurement)
        {
            Console.WriteLine("Measurement packet from {0}",GetName());
            if (measurement != null)
            {
                sendPacket(new PacketMeasurementResponse() { recieveOk = true });
                _storage.AddMeasurement(measurement);
                Console.WriteLine(_server.Monitor.GetName());
                if (_server.Monitor != null)
                    _server.Monitor.sendMeasurement(measurement);
            }
            else
            {
                Console.WriteLine("No measurement recieved/measurement recieve error");
            }
        }

        public override void disconnect(bool disconnect)
        {
            if (disconnect)
            {
                _storage.SaveFile();
                sendPacket(new PacketDisconnectResponse() { disconnectOk = true });
                TcpClient.Close();
                ClientThread.Abort();
                Console.WriteLine("Client closed: {0}",_username);
            }
        }

        public override void receiveChatPacket(PacketChat chat)
        {
            
        }
    }
}
