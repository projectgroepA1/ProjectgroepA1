//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ClientApp
//{
//    class Command
//    {
//        public String name { get; set; }
//        public String command { get; set; }

//        public Command(String commandName, String command)
//        {
//            this.name = commandName;
//            this.command = command;
//        }

//        /*
//        *Write Command
//        */
//        public virtual void CommandAction(Communication com)
//        {
//            com.GetPort().WriteLine(command);
//        }
//    }

//    class NewMode : Command
//    {
//        public NewMode()
//            : base("New mode", "NM")
//        { }

//        /*
//        *New Mode Commands
//        *
//        */
//        public override void CommandAction(Communication com)
//        {
//            String answer, mode;
//            answer = "";
//            mode = "";
//            Console.WriteLine("Time mode press T");
//            Console.WriteLine("Distance mode press D");
//            Console.WriteLine("Set Resistance level press R");
//            answer = Console.ReadLine();
//            if (answer == "T")
//            {
//                mode = "PT";
//                Console.WriteLine("Enter the time (mm:ss)");
//                answer = Console.ReadLine();
//                String[] splitted = answer.Split(':');
//                answer = splitted[0] + splitted[1];
//            }
//            else if (answer == "D")
//            {
//                mode = "PD";
//                Console.WriteLine("Enter the distance in kilometers");
//                answer = Console.ReadLine();
//            }
//            else if (answer == "R")
//            {
//                mode = "PW";
//                Console.WriteLine("Insert Resistance between 25 & 400");
//                answer = Console.ReadLine();
//            }
//            com.GetPort().WriteLine("CM");
//            Thread.Sleep(500);
//            com.GetPort().WriteLine(mode + answer);
//            //Console.WriteLine("To bike: CM");
//            //Console.WriteLine("To bike: "+mode+" "+answer);
//        }
//    }
//}
