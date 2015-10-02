﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetLib;

namespace ClientApp.networking
{
    public class ServerConnection:ClientInterface
    {
        private static string HOSTNAME = "127.0.0.1";
        private static int PORT = 1967;

        private NetworkStream stream;

        public ServerConnection():base()
        {
            TcpClient client = new TcpClient(HOSTNAME, PORT);
            this.stream = client.GetStream();
        }

        public void WritePacket(Packet packet)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(this.stream, packet);
        }

        public Packet ReadPacket()
        {
            Packet packet = (Packet)new BinaryFormatter().Deserialize(this.stream);
            return packet;
        }

        public void loginResponse(bool loginOk)
        {
            if (loginOk)
            {
                //logged in
                Console.WriteLine("log in");

                //
                Application.Run(new Client(this));
            }
            else
            {
                //logged out
                Console.WriteLine("log in aborted");
            }
        }

        public void recieveResponse(bool recieveOk)
        {

        }
    }
}
