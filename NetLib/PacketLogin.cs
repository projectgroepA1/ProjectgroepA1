using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketLogin : Packet
    {
        public String username { get; set; }
        public String password { get; set; }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.login(username, password);
        }
    }
}
