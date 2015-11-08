using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using ClientApp.forms;
using NetLib;
using NetLib.sessionpackets;
using NetLib.sessionpackets.sessions_data;

namespace ClientApp.networking
{
    public class ServerConnection : ClientInterface
    {
        public SslStream Stream { get; set; }
        X509CertificateCollection cCollection = new X509CertificateCollection();
        
        string server = "127.0.0.1";
        private readonly TcpClient _client;
        public Client client { get; set; }
        public List<Tuple<int, int, int, int, int, int, int>> HistoryList { get; set; }
        public string text { get; set; }
        private BinaryFormatter formatter;

        public static bool ValidateServerCertificate(object sender, X509Certificate certificate,
      X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // Accept all certificates
            return true;
        }

        public ServerConnection() : base()
        {
            formatter = new BinaryFormatter();
            _client = new TcpClient(Info.GetIp().ToString(), Info.Port);
            cCollection.Add(new X509Certificate(AppDomain.CurrentDomain.BaseDirectory + "Cert.pfx", "MSsediqima"));
            Stream = new SslStream(_client.GetStream(), false,
        new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
            Stream.AuthenticateAsClient(server, cCollection, System.Security.Authentication.SslProtocols.Default, true);
            //send default packet, that shows this is not an monitor
            WritePacket(new Packet());
        }

        public void WritePacket(Packet packet)
        {
            formatter.Serialize(Stream, packet);
        }

        public void SendHistoryPacket(List<Tuple<int, int, int, int, int, int, int>> List)
        {
            //list en username om te saven
            WritePacket(new PacketHistory() { List = List, username = Login.UserName });
        }

        public Packet ReadPacket()
        {
            Packet packet = (Packet)formatter.Deserialize(Stream);
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

        public static List<Session> Sessions = null;

        public void recievePacketSessions(PacketSessions sessionsPacket)
        {
            Sessions = sessionsPacket.sessions;

            Console.WriteLine("sessions added to the list!");
        }

        public void recievePacketSession(PacketSession ps)
        {
            //client.InsertActuelPDistanceTime(ps.ActualPower,ps.Distance,ps.Time);
            client.InsertTime(ps.Time);
        }
    }
}
