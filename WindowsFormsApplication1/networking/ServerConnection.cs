using System;
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
    public class ServerConnection: ClientInterface
    {
        private NetworkStream stream;

        public Client client { get; set; }

        public ServerConnection():base()
        {
            TcpClient client = new TcpClient(Info.GetIp().ToString(),Info.Port);
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

        public void disconnectResponse(bool disconnectOk)
        {
            
        }

        public void receivePacketChat(PacketChat chat)
        {
            //append text to the App form
            this.client.appendTextToChat(chat.messageText);
        }
    }
}