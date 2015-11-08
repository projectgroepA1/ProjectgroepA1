using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketLoadfile : Packet
    {
        public string fileName;
        public PacketLoadfile(string fileName)
        {
            this.fileName = fileName;
        }
        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.recieveLoadFile(this);
        }
    }
}
