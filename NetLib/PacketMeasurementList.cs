using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketMeasurementList : Packet
    {
        public List<Measurement> measurements { set; get; }

        public PacketMeasurementList(List<Measurement> list)
        {
            this.measurements = list;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.sendMeasurementList();
        }

        public override void handleMonitorSide(MonitorInterface monitorInterface)
        {
            monitorInterface.recieveMeasurementList(this);
        }
    }
}
