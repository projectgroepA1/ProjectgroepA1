using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetLib.sessionpackets;

namespace NetLib
{
    public interface MonitorInterface
    {
        void receiveNewClient(PacketNewClient newClient);
        void receiveMeasurement(PacketMonitorMeasurement measurement);
        void recieveMeasurementList(PacketMeasurementList measurementList);
        void recieveChat(PacketChat pack);
        void recievePacketSessions(PacketSessions sessionsPacket);
    }
}
