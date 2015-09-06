using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace FietsApp
{
    class Communication
    {
        private SerialPort port;
        

        public Communication(string com)
        {
            port = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
            Console.WriteLine("Incoming data");
            Console.WriteLine("");
            Console.WriteLine("Insert 'HELP' to see commands");
            Console.WriteLine("");
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //port.Open();
            //port.WriteLine("ST");
            //{
            //    Thread.Sleep(4000);
            //    port.WriteLine("ST");
            //    Thread.Sleep(100);
            //}
            //System.Windows.Forms.Application.Run();
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string whole = port.ReadLine();
            string[] parts = whole.Split('\t');
            Console.WriteLine("Pulse: " + parts[0] + " Rpm: " + parts[1] + " speed: " + parts[2] + " Distance: " + parts[3] + " Requested Power: " + parts[4] + " Energy: " + parts[5] +
            " Time: " + parts[6] + " actual power: " + parts[7]);
        }

        public SerialPort GetPort()
        {
            return port;
        }

    }
}
