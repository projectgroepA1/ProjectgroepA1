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
            Console.Title = "Server";
        }

        private List<Client> clients = new List<Client>();

        private Monitor _monitor;
        public Monitor Monitor { get { return _monitor; } }
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
                if (!IsMonitor(newClient))
                {
                    Console.WriteLine("is client");
                    clients.Add(new Client(newClient, this));
                }
                else if (_monitor != null)
                {
                    if (!_monitor.TcpClient.Connected)
                    {
                        _monitor = new Monitor(newClient,this,clients);
                    }
                }
                else
                {
                    _monitor = new Monitor(newClient,this,clients);
                }
            }
        }

        private bool IsMonitor(TcpClient client)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Packet packet = (Packet)formatter.Deserialize(client.GetStream());
            //Console.WriteLine(packet.ToString());
            return packet is PacketMonitor;
        }
        
        public void broadCast(Packet packet)
        {
            foreach (Client serverClient in clients)
                serverClient.sendPacket(packet);
        }


        //This Packet can be sent to one specific client.
        public void sendPacketToClient(Packet packet, string clientName, int hashCode)
        {
            foreach (Client serverClient in clients) {
                int code = serverClient.GetHashCode();
                string name = serverClient.GetName();
                    if(code == hashCode && name == clientName)
                    {
                    serverClient.sendPacket(packet);
                    }
            }
        }


    }
}
