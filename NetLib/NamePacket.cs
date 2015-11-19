using System;

namespace NetLib
{
    [Serializable]
    public class NamePacket : Packet
    {
        public string name;
        public int ID;

        public NamePacket(string name, int ID)
        {
            this.name = name;
            this.ID = ID;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.recieveNamePacket(this);
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.recieveNamePacket(this);
        }
    }
}