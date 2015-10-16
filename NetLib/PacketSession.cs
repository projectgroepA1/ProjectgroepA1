using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketSession : Packet
    {
        public string ActualPower { get; }
        public string Time { get; }
        public string Distance { get; }
        public Identifier Identifier { get; }

        public PacketSession(string actualPower, string time, string distance,Identifier identifier)
        {
            ActualPower = actualPower;
            Time = time;
            Distance = distance;
            this.Identifier = identifier;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.receivePacketSession(this);
        }
    }
}
