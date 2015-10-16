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
        public string username { get; }
        public int Id { get; }
        public PacketMonitorMeasurement(PacketMeasurement pack,string username, int id)
            : base(pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse, pack.measurement.pulse)
        {
            this.username = username;
            this.Id = id;
        }

        public override void handleMonitorSide(MonitorInterface monitorInterface)
        {
            monitorInterface.receiveMeasurement(this);
        }
    }
}
