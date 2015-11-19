using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetLib.sessionpackets;

namespace NetLib
{
    public interface ClientInterface
    {

        void loginResponse(bool loginOk);
        void recieveResponse(bool recieveOk);
        void disconnectResponse(bool disconnectOk);
        void recievePacketChat(PacketChat chat);
        void recievePacketBicycleCommand(PacketBicycleCommand command);
        void recievePacketSession(PacketSession ps);
        void recievePacketSessions(PacketSessions sessionsPacket);
        void recieveNamePacket(NamePacket namePacket);
    }
}
