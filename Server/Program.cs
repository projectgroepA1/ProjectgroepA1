using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetwerkLib;
namespace Server
{
    class Program
    {
        private static void Main(string[] args)
        {
            new Program();
        }

        private List<ServerClient> clients = new List<ServerClient>();

        Program()
        {
            TcpListener listener = new TcpListener(1000);
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
