using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace NetLib
{
    interface ServerInterface
    {

        void login(string username, string password);
    }
}
