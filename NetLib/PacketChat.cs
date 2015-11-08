using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketChat:Packet
    {
        public string messageText { get; }

        public string hostName { get; }
        public string destination { get; }

        public int destinationID { get; }
       
        public PacketChat(string message, string host, string destination, int id)
        {
            this.messageText = message;
            this.hostName = host;
            this.destination = destination;
            this.destinationID = id;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.receiveChatPacket(this);
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.recievePacketChat(this);
        }

        public override void handleMonitorSide(MonitorInterface monitorInterface)
        {
            monitorInterface.recieveChat(this);
        }
    }
}
