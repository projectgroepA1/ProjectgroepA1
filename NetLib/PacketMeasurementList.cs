using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    public class PacketMeasurementList : Packet
    {
        public List<Measurement> measurements { set; get; }

        public PacketMeasurementList(List<Measurement> list)
        {
            this.measurements = list;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.sendMeasurementList(this);
        }
    }
}
