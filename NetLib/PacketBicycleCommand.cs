using System;

namespace NetLib
{
    [Serializable]
    public class PacketBicycleCommand : Packet
    {
        public string command { get; }
        public int destinationID { get; }
        public string name { get; }

        public PacketBicycleCommand(string command, int id)
        {
            this.command = command;
            destinationID = id;
            this.name = "NopeNope";
        }

        public PacketBicycleCommand(string command, int id, string name)
        {
            this.command = command;
            destinationID = id;
            this.name = name;
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