using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    class PacketMeasurement : Packet
    {



        public override void handleServerSide(ServerInterface serverInterface)
        {
            //serverInterface.login();
        }
    }
}
