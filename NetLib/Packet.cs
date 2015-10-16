using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class Packet
    {
        public virtual void handleClientSide(ClientInterface clientInterface)
        { }
        public virtual void handleServerSide(ServerInterface serverInterface)
        { }
        public virtual void handleMonitorSide(MonitorInterface monitorInterface)
        { }
    }
}
