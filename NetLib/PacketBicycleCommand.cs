using System;

namespace NetLib
{
    [Serializable]
    public class PacketBicycleCommand : Packet
    {
        public string command { get; }
        public int destinationID { get; }

        public PacketBicycleCommand(string command, int id)
        {
            this.command = command;
            destinationID = id;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.recievePacketBicycleCommand(this);
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.receivePacketBicycleCommand(this);
        }
    }
}