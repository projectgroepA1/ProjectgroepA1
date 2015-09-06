using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FietsApp
{
    class Parser
    {
        private List<Command> commands;

        public Parser()
        {
            commands = new List<Command>();
            commands.Add(new Command("Reset", "RS"));
            commands.Add(new Command("New mode", "NM"));
            commands.Add(new Command("Status report", "ST"));
            commands.Add(new Command("Help", "HELP"));
        }

        public void SendCommand(String command)
        {
            //Console.WriteLine(command);
            String[] splitCommands = command.Split(' ', '\t');
            //Console.WriteLine("-"+splitCommands[0]);
            bool recognized = false;
            for (int i = 0; i < commands.Count; i++)
            {
                if (splitCommands[0] == commands.ElementAt(i).command)
                {
                    recognized = true;
                    Console.WriteLine(commands.ElementAt(i).name);
                    break;
                }
            }
            if (!recognized)
            {
                Console.WriteLine("Command not recognized.");
            }

        }
    }
}
