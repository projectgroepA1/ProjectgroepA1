using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetLib;

namespace Server
{
    abstract class ServerClient : ServerInterface
    {
        public TcpClient TcpClient { get; set; }
        public NetworkStream Stream { get; set; }

        private Thread _clientThread;
        public Thread ClientThread
        {
            get { return _clientThread; }
        }

        protected Program _server;
        protected BinaryFormatter formatter;

        public ServerClient(TcpClient client, Program server)
        {
            this.TcpClient = client;
            this.Stream = client.GetStream();
            this._server = server;
            formatter = new BinaryFormatter();
            //Console.WriteLine("Connected: {0}\tHashCode: ", GetHashCode());
            ThreadStart();
        }

        public void ThreadClient()
        {
            Console.WriteLine("{0}\tStarted{1}",GetHashCode(),"");
            while (TcpClient.Connected)
            {
                 
                Packet packet = (Packet)formatter.Deserialize(Stream);
                packet.handleServerSide(this);
                Console.WriteLine("Packet received from: {0}",GetHashCode());
                //Console.WriteLine("packet received from {0}", packet.GetName());

                if(packet is PacketChat)
                {
                    PacketChat chatPacket = (PacketChat)packet;
                    Console.WriteLine("Hostname: {0}, destination: {1}, destinationID: {2}", chatPacket.hostName, chatPacket.destination, chatPacket.destinationID);
                }
            }
        }

        private void ThreadStart()
        {
            _clientThread = new Thread(new ThreadStart(ThreadClient));
            _clientThread.Start();
        }

        public abstract void login(string username, string password);

        public abstract void sendMeasurement(PacketMeasurement measurement);

        public void sendPacket(Packet packet)
        {
            formatter.Serialize(Stream, packet);
        }

        public abstract void disconnect(bool disconnect);


        public void receiveChatPacket(PacketChat chat)
        {
            if(chat.destination == "monitor")
            {
                _server.sendPackToMonitor(chat);
                Console.WriteLine("Sent Pack to monitor");
            }
            else
            {
                _server.sendPacketToClient(chat, chat.destinationID);
                Console.WriteLine("Sent Pack to client");
            }
        }

        public void Close()
        {
            TcpClient.Close();
           _clientThread.Abort(); 
        }

        public abstract void sendNewClient(Identifier identifier);

        public abstract void getMeasurements(string fileName);

        public abstract void sendMeasurementList();

        public virtual void receivePacketSession(PacketSession ps)
        {

        }

        public void sendMeasurementList(PacketMeasurementList mes)
        {

        }
    }
}
