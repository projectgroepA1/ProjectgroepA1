using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetLib;

namespace ClientApp.networking
{
    class ServerConnection
    {
        private static string HOSTNAME = "127.0.0.1";
        private static int PORT = 1967;


        public ServerConnection():base()
        {
            TcpClient client = new TcpClient(HOSTNAME, PORT);

            //login
            PacketLogin loginPacket = new PacketLogin() {username = "admin", password = "12345" };
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(client.GetStream(), loginPacket);

            //wait to receive a packet


            while (client.Connected)
            {
                //while connected

                
            }

        }
    }
}
