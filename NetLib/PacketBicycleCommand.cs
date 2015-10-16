namespace NetLib
{
    public class PacketBicycleCommand : Packet
    {
        public string command { get; }

        public PacketBicycleCommand(string command)
        {
            this.command = command;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.recievePacketBicycleCommand(this);
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {

        }
    }
}