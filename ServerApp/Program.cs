using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            String input = "";
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                Console.WriteLine("Connected to internet");
                Server s = new Server();
                Thread serverThread = new Thread(s.ServerSetUp);
                serverThread.Start();
            }
            else
            {
                Console.WriteLine("Not connected to internet");
            }
            while (running)
            {
                input = Console.ReadLine();           
                if (input.ToLower() == "q")
                {
                    running = false;
                }                
            }          
        }
    }
}
