using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    class PacketBicycleCommand:Packet
    {

        string command { get; }

        public PacketBicycleCommand(string command)
        {
            this.command = command;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {

        }

        public override void handleClientSide(ClientInterface clientInterface)
        {

        }
    }
}
