using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FietsApp
{
    class Application
    {
        private Communication communication;
        private Parser parser;
        private DataStorage storage;
        public Application(string com)
        {
            communication = new Communication(com);
            storage = new DataStorage("Dokter harrie", "Tim");
            parser = new Parser(communication, storage);

            /*
            *Running loop
            */
            bool running = true;
            while (running)
            {
            String command = Console.ReadLine();
             parser.SendCommand(command);
                /*
                *If input is 'q' the program stops
                */
                if (command == "q")
                {
                    running = false;
                }
                /*
                *If input is 'HELP' the gives all possible commands
                */
                else if (command == "HELP")
                {
                    Console.WriteLine("");
                    Console.WriteLine("The following commands can be used:");
                    Console.WriteLine("ST: Request hometrainer status");
                    Console.WriteLine("RS: Reset system");
                    Console.WriteLine("NM: New Mode");
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("");
                }
            }
        }
    }
}
