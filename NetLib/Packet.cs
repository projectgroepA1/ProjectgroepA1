using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    class Packet
    {
        public virtual void handleClientSide(ClientInterface clientInterface)
        { }
        public virtual void handleServerSide(ServerInterface serverInterface)
        { }
    }
}
