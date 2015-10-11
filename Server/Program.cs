using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
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

        private List<Client> clients = new List<Client>();

        Program()
        {
            IPAddress ip = Info.GetIp();
            TcpListener listener = new TcpListener(ip,Info.Port);
            listener.Start();

            Monitor monitor = null;

            Console.WriteLine("Server started: {0}",DateTime.Now);
            Console.WriteLine("Server ip: {0}", ip);
            Console.WriteLine("Server port: {0}",Info.Port);
            while (true)
            {
                TcpClient newClient = listener.AcceptTcpClient();
                if (!IsMonitor(newClient))
                {
                    clients.Add(new Client(newClient, this));
                }
                else if (monitor != null)
                {
                    if (!monitor.TcpClient.Connected)
                    {
                        monitor = new Monitor(newClient,this);
                    }
                }
                else
                {
                    monitor = new Monitor(newClient,this);
                }
            }
        }

        private bool IsMonitor(TcpClient client)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Packet packet = (Packet)formatter.Deserialize(client.GetStream());
            return packet is PacketMonitor;
        }
        
        public void broadCast(Packet packet)
        {
            foreach (Client serverClient in clients)
                serverClient.sendPacket(packet);
        }




    }
}
