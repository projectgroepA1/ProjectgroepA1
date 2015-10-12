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
       
        public PacketChat(string message)
        {
            this.messageText = message;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.receiveChatPacket(this);
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.recievePacketChat(this);
        }
    }
}
