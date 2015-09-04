using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FietsApp
{
    class Program
    {
        private Communication comm;
        static void Main(string[] args)
        {
            Communication comm = new Communication("COM3");
        }
    }
}
