using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketDisconnect : Packet
    {
        public bool disconnected { get; set; }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.disconnect(disconnected);
        }

    }
}
