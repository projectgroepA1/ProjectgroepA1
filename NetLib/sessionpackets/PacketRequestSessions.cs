using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib.sessionpackets
{
    [Serializable]
    public class PacketRequestSessions : Packet
    {
        public int id { get; set; }
        public string username { get; set; }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.receivePacketRequestSessions(this);
        }
    }
}
