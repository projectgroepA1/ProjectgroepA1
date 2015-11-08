using System;
using System.Collections.Generic;

namespace NetLib
{
    [Serializable]
    public class PacketHistory : Packet
    {

        public List<Tuple<int, int, int, int, int, int, int>> List { get; set; }

        public string username;

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.recievePacketHistory(List, username);
        }
    }
}