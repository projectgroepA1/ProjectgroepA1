using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketMonitorMeasurement : PacketMeasurement
    {
        public Identifier identifier { get; }
        public PacketMonitorMeasurement(PacketMeasurement pack,Identifier id)
            : base(pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse)
        {
            identifier = id;
        }

        public override void handleMonitorSide(MonitorInterface monitorInterface)
        {
            monitorInterface.receiveMeasurement(this);
        }
    }
}
