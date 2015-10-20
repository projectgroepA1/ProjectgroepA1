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
            : base(pack.measurement.pulse, pack.measurement.RPM, pack.measurement.speed, pack.measurement.distance, pack.measurement.power, pack.measurement.energy, pack.measurement.time, pack.measurement.AP)
        {
            identifier = id;
        }

        public override void handleMonitorSide(MonitorInterface monitorInterface)
        {
            monitorInterface.receiveMeasurement(this);
        }
    }
}
