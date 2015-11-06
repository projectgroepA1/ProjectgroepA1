using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetLib.sessionpackets.sessions_data;

namespace NetLib.sessionpackets
{
    [Serializable]
    public class PacketSessions : Packet
    {
        public List<Session> sessions { get; }

        public PacketSessions(List<Session> sessions)
        {
            this.sessions = sessions;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.recievePacketSessions(this);
        }

        public override void handleMonitorSide(MonitorInterface monitorInterface)
        {
            monitorInterface.recievePacketSessions(this);
        }
    }
}
