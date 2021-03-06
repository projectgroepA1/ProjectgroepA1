﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketDisconnectResponse : Packet
    {
        public bool disconnectOk { get; set; }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.disconnectResponse(disconnectOk);
        }
    }
}
