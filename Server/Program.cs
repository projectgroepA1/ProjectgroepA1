using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using NetLib;

namespace Server
{
    class Program
    {
        public DataStorage storage;

        private static void Main(string[] args)
        {
            new Program();
        }

        private List<ServerClient> clients = new List<ServerClient>();

        Program()
        {
            IPAddress ip = Info.GetIp();
            TcpListener listener = new TcpListener(ip,Info.Port);
            listener.Start();

            Console.WriteLine("Server started: {0}",DateTime.Now);
            Console.WriteLine("Server ip: {0}", ip);
            Console.WriteLine("Server port: {0}",Info.Port);
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
