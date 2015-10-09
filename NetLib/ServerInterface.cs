using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace NetLib
{
    public interface ServerInterface
    {
        void login(string username, string password);

        void receiveChatPacket(PacketChat packetChat);
    }
}
