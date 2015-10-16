using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using NetLib;
using MonitoringApp_V2;

namespace ClientApp.networking
{
    public class ServerConnection: ClientInterface
    {
        private readonly TcpClient _client;
        public Form1 client { get; set; }

        public ServerConnection():base()
        {
            _client = new TcpClient(Info.GetIp().ToString(),Info.Port);
            //send default packet, that shows this is not an monitor
            WritePacket(new Packet());
        }

        public void WritePacket(Packet packet)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(this._client.GetStream(), packet);
        }

        public Packet ReadPacket()
        {
            Packet packet = (Packet)new BinaryFormatter().Deserialize(this._client.GetStream());
            return packet;
        }

        public void loginResponse(bool loginOk)
        {
            if (loginOk)
            {
                //logged in
                Console.WriteLine("log in");
                
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
            if (disconnectOk)
            {
                client.thread.Abort();
                _client.Close();
            }
        }

        public void recievePacketChat(PacketChat chat)
        {
            //append text to the App form
            //this.client.appendTextToChat("[dokter] " + chat.messageText + Environment.NewLine);

            List<Client> clients = this.client.clients;

            foreach (Client client in clients)
            {
                if (client.Identifier.Id == chat.destinationID)
                {
                    client.Panel.changeChatBoxText("[dokter] " + chat.messageText + Environment.NewLine);
                }
            }


        }

        public void recievePacketBicycleCommand(PacketBicycleCommand command)
        {
            //N.V.T in de monitor
            //this.client.sendCommand(command.command);
        }

        public void recievePacketSession(PacketSession ps)
        {
            throw new NotImplementedException();
        }
    }
}
