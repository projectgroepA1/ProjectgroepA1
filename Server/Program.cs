using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using NetLib;
using System.Windows.Forms;
namespace Server
{
    class Program
    {
        public DataStorage storage;
        private static string path = AppDomain.CurrentDomain.BaseDirectory +  "Ti2.1-cert.pfx";
        public X509Certificate2 cert = new X509Certificate2(path, "MSsediqima");
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
            storage = new DataStorage();
            listener.Start();
            int counter = 0;
            Console.WriteLine("Server started: {0}",DateTime.Now);
            Console.WriteLine("Server ip: {0}", ip);
            Console.WriteLine("Server port: {0}",Info.Port);

            while (true)
            {
                TcpClient newClient = listener.AcceptTcpClient();
                if (!IsMonitor(newClient))
                {
                    counter++;
                    Console.WriteLine("is client");
                    Client client = new Client(newClient, this, counter, storage);
                    clients.Add(client);
                }
                else if (_monitor != null)
                {
                    if (!_monitor.TcpClient.Connected)
                    {
                        _monitor = new Monitor(newClient,this,clients, storage);
                    }
                }
                else
                {
                    _monitor = new Monitor(newClient,this,clients, storage);
                }
            }
        }

        public void ResetMonitor()
        {
            _monitor.Close();
            _monitor = null;
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
        public void sendPacketToClient(Packet packet, int destination)
        {
            foreach (Client serverClient in clients) {
                if(serverClient.identifier.Id == destination)
                {
                    serverClient.sendPacket(packet);
                    Console.WriteLine("Message sent to packet {0}", serverClient.identifier.Id);

                    break;
                }
            }
        }

        public void sendPackToMonitor(Packet packet)
        {
            _monitor.sendPacket(packet);
            Console.WriteLine("Packet sent to monitor");
        }

        public static bool ValidateClientCertificate(object sender, X509Certificate certificate,
         X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // Accept all certificates
            return true;
        }

    }
}
