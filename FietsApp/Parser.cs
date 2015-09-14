using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FietsApp
{
    class Parser
    {
        private List<Command> commands;
        private Communication com;


        public Parser(Communication com)
        {
            this.com = com;
            commands = new List<Command>();
            commands.Add(new Command("Reset", "RS"));
            commands.Add(new NewMode());
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
                    //Console.WriteLine(commands.ElementAt(i).name);
                    
                    commands.ElementAt(i).CommandAction(this.com);
                    if (splitCommands[0] == "ST")
                    {
                        try
                        {
                        string whole = com.GetPort().ReadLine();
                        string[] parts = whole.Split('\t');
                        Console.WriteLine("Pulse: " + parts[0] + " Rpm: " + parts[1] + " speed: " + parts[2] + " Distance: " + parts[3] + " Requested Power: " + parts[4] + " Energy: " + parts[5] +
                        " Time: " + parts[6] + " actual power: " + parts[7]);
                        }catch(IndexOutOfRangeException ex)
                        {
                            Console.WriteLine("No Data Recieved");
                        }
                    }
                    Console.WriteLine("Type new command in 5...");
                    for(int count = 4; i > 0; i--)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine(count + "...");
                    }
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
