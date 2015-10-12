using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    public class Info
    {
        public const int Port = 1967;

        public static IPAddress GetIp()
        {
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ip = ipHostInfo.AddressList[0];
            return ip;
        }
    }
}
