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
    class ServerClient : ServerInterface
    {
        public NetworkStream stream { get; set; }
        public TcpClient tcpClient { get; set; }
        private Program server;

        private string username;

        public ServerClient(TcpClient tcpClient, Program server)
        {
            this.server = server;
            this.tcpClient = tcpClient;
            stream = tcpClient.GetStream();
            new Thread(() =>
            {
                BinaryFormatter formatter = new BinaryFormatter();
                while (tcpClient.Connected)
                {
                    Packet packet = (Packet)formatter.Deserialize(stream);
                    packet.handleServerSide(this);
                }
            }).Start();
        }


        public void login(string username, string password)
        {
            this.username = username;
            if (username == "admin" && password == "12345")
            {
                sendPacket(new PacketLoginResponse() { loginOk = true });
            }

        }

        public void sendPacket(Packet packet)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, packet);
        }
    }
}
