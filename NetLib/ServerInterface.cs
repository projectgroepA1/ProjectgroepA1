using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

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
    }
}
