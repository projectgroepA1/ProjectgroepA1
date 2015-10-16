using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketNewClient : Packet
    {
        public string usename { get; set; }
        public int counter { get; set; }

        public override void handleMonitorSide(MonitorInterface monitorInterface)
        {
            monitorInterface.receiveNewClient(this);
        }
    }
}
