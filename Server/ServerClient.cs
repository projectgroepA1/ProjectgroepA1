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
            Console.WriteLine("Connected: {0}\tHashCode: {1}",GetName(),GetHashCode());
            ThreadStart();
        }

        public void ThreadClient()
        {
            Console.WriteLine("{0}\tStarted{1}",GetName(),"");
            while (TcpClient.Connected)
            {
                Packet packet = (Packet)formatter.Deserialize(Stream);
                packet.handleServerSide(this);
                Console.WriteLine("packet received from {0}",GetName());
            }
        }

        public abstract string GetName();

        private void ThreadStart()
        {
            _clientThread = new Thread(new ThreadStart(ThreadClient));
            _clientThread.Start();
        }

        public abstract void login(string username, string password);

        public abstract void sendMeasurement(Measurement measurement);

        public void sendPacket(Packet packet)
        {
            formatter.Serialize(Stream, packet);
        }

        public abstract void disconnect(bool disconnect);

        public abstract void receiveChatPacket(PacketChat chat);

        public void Close()
        {
            TcpClient.Close();
           _clientThread.Abort(); 
        }

        public abstract void sendNewClient(string username, int hashcode);
    }
}
