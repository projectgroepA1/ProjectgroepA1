using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FietsApp
{
    class Command
    {
        public String name { get; set; }
        public String command { get; set; }

        public Command(String commandName, String command)
        {
            this.name = commandName;
            this.command = command;
        }

        public void CommandAction(Communication com)
        {
            com.GetPort().WriteLine(command);
        }
    }
}
