﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace FietsSim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            SerialPort port = new SerialPort("COM9");
            port.Open();

            //string txt = portWrite();
            //port.WriteLine(txt);

            //receive handler
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            while (true)
            {

            }

            //port.Close();
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.Write("Data Received: " + indata);
            bool a = (indata == "ST\n");

            if (a)
            {
                Console.WriteLine("indata is ST just received this");
                sp.WriteLine(portWrite());
            }
            else
            {
                //command like set the mode etc
                if (indata == "RS\n")
                {
                    //reset the bicycle
                }
           
            }
        }


        private static string portWrite()
        {
            String totalString = "";

            //0       0       0       4       400     57      01:05   0
            //pulse - rpm - speed - distance - requestpower - energy - tijd - actual power

            string pulse = RandomValue(300, 600, 350) + "";
            string rpm = RandomValue(0, 300, 150) + "";
            string speed = RandomValue(0, 50, 25) + "";
            string distance = "5";
            string requestpower = "500";
            string energy = RandomValue(0, 100, 50) + "";
            string time = "01:05";
            string actualpower = RandomValue(0, 1000, 400) + "";

            totalString += pulse + '\t';
            totalString += rpm + '\t';
            totalString += speed + '\t';
            totalString += distance + '\t';
            totalString += requestpower + '\t';
            totalString += energy + '\t';
            totalString += time + '\t';
            totalString += actualpower + '\t';

            return totalString;
        }

        public static void SendReset(SerialPort sp)
        {
            sp.WriteLine("ST");
        }

        private static int RandomValue(int min, int max, int current)
        {
            Random random = new Random();
            int next = (int)(random.NextDouble() * 10);

            //positive or negative
            if (random.Next() < 5)
            {
                int newValue = current + next;
                if (newValue >= min && newValue <= max)
                {
                    return newValue;
                }
                return RandomValue(min, max, current);
            }
            else
            {
                int newValue = current - next;
                if (newValue >= min && newValue <= max)
                {
                    return newValue;
                }
                return RandomValue(min, max, current);
            }
        }
    }
}
