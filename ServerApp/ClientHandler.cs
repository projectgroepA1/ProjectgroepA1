using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace ServerApp
{
    class ClientHandler
    {
        private TcpClient tc;
        private Server server;

        public ClientHandler(TcpClient tc,Server server)
        {
            this.tc = tc;
            this.server = server;
        }

        public void ClientSetUp(Object b)
        {
            
        }
    }
}
