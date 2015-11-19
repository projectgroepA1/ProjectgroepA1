using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using NetLib.sessionpackets;

namespace NetLib
{
    public interface ServerInterface
    {
        void login(string username, string password);
        void sendMeasurement(PacketMeasurement measurement);
        void disconnect(bool disconnect);
        void receiveChatPacket(PacketChat packetChat);
        void sendNewClient(Identifier identifier);
        void sendMeasurementList();
        void receivePacketSession(PacketSession ps);
        void recieveLoadFile(PacketLoadfile lf);
        void receivePacketBicycleCommand(PacketBicycleCommand packetBicycleCommand);
        void recievePacketHistory(List<Tuple<int, int, int, int, int, int, int>> list, string username);
        void receivePacketRequestSessions(PacketRequestSessions sessions);
        void recieveNamePacket(NamePacket namePacket);
    }
}
