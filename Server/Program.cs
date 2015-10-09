using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using NetLib;

namespace Server
{
    class Program
    {
        public IPAddress IP { get; set; }
        public static readonly int port = 1967;
        public DataStorage storage;

        private static void Main(string[] args)
        {
            new Program();
        }

        private List<ServerClient> clients = new List<ServerClient>();

        Program()
        {
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IP = ipHostInfo.AddressList[0];
            TcpListener listener = new TcpListener(IP,port);
            listener.Start();

            while (true)
            {
                TcpClient newClient = listener.AcceptTcpClient();
                clients.Add(new ServerClient(newClient, this));
            }
        }


        public void broadCast(Packet packet)
        {
            foreach (ServerClient serverClient in clients)
                serverClient.sendPacket(packet);
        }




    }
}
