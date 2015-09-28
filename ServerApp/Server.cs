using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace ServerApp
{
    class Server
    {
        public IPAddress IP { get; set; }
        public static readonly int Port = 1967;
        private TcpListener serverListener;
        private List<Tuple<ClientHandler, Thread>> clients;

        public Server()
        {
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IP = ipHostInfo.AddressList[0];
            clients = new List<Tuple<ClientHandler, Thread>>(); 
            Console.WriteLine("Server IP-address: {0}",IP.ToString());
            serverListener = new TcpListener(IP,Port);
        }

        public void ServerSetUp(Object ob)
        {
            serverListener.Start();
            while(true)
            {
                //test code, om client toe te kunnen voegen aan de server
                Thread.Sleep(1000);
                TcpClient tc = new TcpClient(IP.ToString(), Port);
                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                //tot hier


                TcpClient tcTest = serverListener.AcceptTcpClient();
                ClientHandler clientHandler = new ClientHandler(tcTest,this);
                Thread clientThread = new Thread(clientHandler.ClientSetUp);
                clients.Add(new Tuple<ClientHandler,Thread>(clientHandler,clientThread));
                clientThread.Start();                
            }
        }
    }
}
