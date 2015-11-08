using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetLib;
using NetLib.sessionpackets;
using NetLib.sessionpackets.sessions_data;

namespace Server
{
    abstract class ServerClient : ServerInterface
    {


        public TcpClient TcpClient { get; set; }
        //public NetworkStream Stream { get; set; }
        public SslStream Stream { get; set; }


        private Thread _clientThread;
        public Thread ClientThread
        {
            get { return _clientThread; }
        }

        protected Program _server;
        protected BinaryFormatter formatter;

        public ServerClient(TcpClient client, Program server, X509Certificate2 certificate)
        {
            Stream = new SslStream(client.GetStream(), false,
                new RemoteCertificateValidationCallback(ValidateClientCertificate), null);
            try
            {
                Stream.AuthenticateAsServer(certificate, true, SslProtocols.Tls, true);

            }
            catch (AuthenticationException e)
            {

                Console.WriteLine("Exception: {0}", e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine("Inner exception: {0}", e.InnerException.Message);
                }
                Console.WriteLine("Authentication failed - closing the connection.");
                Stream.Close();
                client.Close();
                return;
            }

            this.TcpClient = client;
            //this.Stream = client.GetStream();
            this._server = server;
            formatter = new BinaryFormatter();
            //Console.WriteLine("Connected: {0}\tHashCode: ", GetHashCode());
            ThreadStart();
        }

        public void ThreadClient()
        {
            Console.WriteLine("{0}\tStarted{1}", GetHashCode(), "");
            while (TcpClient.Connected)
            {

                Packet packet = (Packet)formatter.Deserialize(Stream);
                packet.handleServerSide(this);
                Console.WriteLine("Packet received from: {0}", GetHashCode());
                //Console.WriteLine("packet received from {0}", packet.GetName());

                if (packet is PacketChat)
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
            if (chat.destination == "monitor")
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

        public void receivePacketBicycleCommand(PacketBicycleCommand packetBicycleCommand)
        {
            _server.sendPacketToClient(packetBicycleCommand, packetBicycleCommand.destinationID);
            Console.WriteLine("Sent Command Pack to client");
        }

        public void recievePacketHistory(List<Tuple<int, int, int, int, int, int, int>> list, string username)
        {
            Session session = new Session(list, username);

            //write file
            var file = File.Open(AppDomain.CurrentDomain.BaseDirectory + username + DataStorage.GetUniqueNumber() + ".session", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, session);
            file.Close();
        }

        public void sendMeasurementList(PacketMeasurementList mes)
        {

        }

        public void recieveLoadFile(PacketLoadfile lf)
        {
            List<Measurement> list = _server.storage.LoadFile(lf.fileName);
            _server.sendPackToMonitor(new PacketMeasurementList(list));
            Console.WriteLine("Sent package to monitor");
        }

        public void receivePacketRequestSessions(PacketRequestSessions sessionsPacket)
        {
            List<Session> sessions = new List<Session>();

            //loop through the files in de dir (CHECKED)
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(files);

            int id = 0;

            foreach (string file in files)
            {
                if (file.Contains(".session") && (file.Contains(sessionsPacket.username) || sessionsPacket.username == "monitor"))
                {
                    //file belongs to the user
                    var fil2e = File.Open(file, FileMode.Open);

                    //read the data
                    BinaryFormatter formatter = new BinaryFormatter();
                    Session session = (Session)formatter.Deserialize(fil2e);

                    //get id from the filename
                    session.ID = id;
                    id++;

                    //add sessions to the list
                    sessions.Add(session);

                    //close
                    fil2e.Close();
                }
            }

            PacketSessions packetSessions = new PacketSessions(sessions);

            if (sessionsPacket.username == "monitor")
            {
                _server.sendPackToMonitor(packetSessions);
            }
            else
            {
                _server.sendPacketToClient(packetSessions, sessionsPacket.id);
            }
        }

        public static bool ValidateClientCertificate(object sender, X509Certificate certificate,
    X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // Accept all certificates
            return true;
        }
    }
}
