using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketMeasurementResponse : Packet
    {
        public bool recieveOk { get; set; }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.recieveResponse(recieveOk);
        }

    }
}
