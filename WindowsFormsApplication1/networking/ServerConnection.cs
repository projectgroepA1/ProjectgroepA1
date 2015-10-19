﻿using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using NetLib;

namespace ClientApp.networking
{
    public class ServerConnection: ClientInterface
    {
        private readonly TcpClient _client;
        public Client client { get; set; }

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

                //
                //Application.Run(new Client(this, client.hostName, client.id));
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
                client.fromServer.Abort();
                _client.Close();
            }
        }

        public void recievePacketChat(PacketChat chat)
        {
            //append text to the App form
            this.client.appendTextToChat("[doctor] " + chat.messageText);
        }

        public void recievePacketBicycleCommand(PacketBicycleCommand command)
        {
            this.client.reader.sendCommand(command.command);
        }

        public void recievePacketSession(PacketSession ps)
        {
            //client.InsertActuelPDistanceTime(ps.ActualPower,ps.Distance,ps.Time);
            client.InsertTime(ps.Time);
        }
    }
}
