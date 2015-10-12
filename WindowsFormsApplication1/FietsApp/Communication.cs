using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace ClientApp
{
    public class Communication
    {
        private SerialPort port;
        public string[] parts { get; set; }
        private string[] oldParts = { "0", "0", "0", "0", "0", "0", "0", "0" };

        public Communication(string com)
        {
            port = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            //port.Open();

            Thread thread = new Thread(new ThreadStart(dataAsker));
            thread.Start();
        }

        public void sendCommand(string command)
        {
            this.port.WriteLine(command);
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (port.ReadLine() == "")
            {
                parts = oldParts;
            }
            else
            {
                string whole = port.ReadLine();
                parts = whole.Split('\t');
                //oldParts = parts;
            }
            foreach (string kappa in parts)
            {
                Console.WriteLine("recieved string: " + kappa);
            }
            //Console.WriteLine("recieved string:" + parts);
            //Console.WriteLine("Pulse: " + parts[0] + " Rpm: " + parts[1] + " speed: " + parts[2] + " Distance: " + parts[3] + " Requested Power: " + parts[4] + " Energy: " + parts[5] +
            //" Time: " + parts[6] + " actual power: " + parts[7]);
        }

        private void dataAsker()
        {
            while (true)
            {
                port.WriteLine("ST");
                Thread.Sleep(1000);
            }
        }
    }
}
