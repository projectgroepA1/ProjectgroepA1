using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FietsApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            new Application("COM3");
        }
    }
}
