using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetLib;
using System.Windows.Forms;

namespace Server
{
    class Client : ServerClient
    {
        private readonly DataStorage _storage;
        public Identifier identifier;

        public Client(TcpClient tcpClient, Program server, int number, DataStorage storage) : base(tcpClient,server)
        {
            this._storage = storage;
            identifier = new Identifier("",number);
        }

        public override void login(string username, string password)
        {
            identifier.Username = username;
            if (username == "admin" && password == "12345")
            {
                sendPacket(new PacketLoginResponse() {loginOk = true, number = this.identifier.Id});
                if (_server.Monitor != null)
                {
                    _server.Monitor.sendNewClient(identifier);
                }
                else
                {
                    MessageBox.Show("You have to open the monitor first");
                }
            }
            else
            {
                sendPacket(new PacketLoginResponse() {loginOk = false, number = 0 });
            }

        }

        public override void sendMeasurement(PacketMeasurement pack)
        {
            Console.WriteLine("Measurement packet from: {0}",pack.ToString());
            if (pack.measurement != null)
            {
                sendPacket(new PacketMeasurementResponse() { recieveOk = true });
                _storage.AddMeasurement(pack.measurement);
                if (_server.Monitor != null)
                {
                    _server.Monitor.sendMeasurement(new PacketMonitorMeasurement(pack,identifier));;
                }
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
                Console.WriteLine("Client closed: {0}",identifier.Username);
            }
        }
        
        public override void sendNewClient(Identifier identifier)
        {
            _server.Monitor.sendPacket(new PacketNewClient() {Identifier = identifier});
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
    }
}
