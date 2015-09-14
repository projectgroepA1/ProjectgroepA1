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
        private DataStorage storage;


        public Parser(Communication com, DataStorage storage)
        {
            this.com = com;
            this.storage = storage;
            commands = new List<Command>();
            commands.Add(new Command("Reset", "RS"));
            commands.Add(new NewMode());
            commands.Add(new Command("Status report", "ST"));
            commands.Add(new Command("Help", "HELP"));
            commands.Add(new Command("Write data", "WD"));
            commands.Add(new Command("Read data", "RD"));
            commands.Add(new Command("Print data", "PD"));
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
                        storage.addData(whole);
                        string[] parts = whole.Split('\t');
                        Console.WriteLine("Pulse: " + parts[0] + " Rpm: " + parts[1] + " speed: " + parts[2] + " Distance: " + parts[3] + " Requested Power: " + parts[4] + " Energy: " + parts[5] +
                        " Time: " + parts[6] + " actual power: " + parts[7]);
                        }catch(IndexOutOfRangeException ex)
                        {
                            Console.WriteLine("No Data Recieved");
                        }
                    }
                    if (splitCommands[0] == "WD")
                    {
                        storage.writeData();
                    }
                    if (splitCommands[0] == "RD")
                    {
                        storage.readData();
                    }
                    if (splitCommands[0] == "PD")
                    {
                        foreach (string line in storage.data)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    Console.WriteLine("Type new command in 5...");
                    Thread.Sleep(1000);
                    Console.WriteLine("...4");
                    Thread.Sleep(1000);
                    Console.WriteLine("...3");
                    Thread.Sleep(1000);
                    Console.WriteLine("...2");
                    Thread.Sleep(1000);
                    Console.WriteLine("...1");
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
