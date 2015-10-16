using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MonitoringApp_V2;
using NetLib;

namespace WindowsFormsApplication2
{
    class Connection : MonitorInterface
    {
        public bool running { get; set; }
        private Form1 form;
        private BinaryFormatter formatter;


        public Connection(Form1 form)
        {
            this.form = form;
            formatter = new BinaryFormatter();
            running = true;
        }

        public void receiveNewClient(PacketNewClient newClient)
        {
            MessageBox.Show("Yeah new client");
            DataPanel panel = new DataPanel(form);
            Client client = new Client(newClient.usename, newClient.counter, panel);
            form.clients.Add(client);
            form.AddPanel(panel);
        }

        public void receiveMeasurement(PacketMeasurement m)
        {
            form.Invoke((Action)(() =>
            {
                try
                {
                    foreach (Client c in form.clients)
                    //{
                    //    if (!p.ReturnRPM().Focused)
                    //    {
                    //        p.ReturnRPM().Text = r.Next(1, 50).ToString();
                    //    }
                    //    p.ReturnTimeTextBox().Text = r.Next(1, 50).ToString();
                    //    p.ReturnPowerTextBox().Text = r.Next(1, 50).ToString();
                    //    p.ReturnEnergyTextBox().Text = r.Next(1, 50).ToString();
                    //    p.ReturnActualPowerTextBox().Text = r.Next(1, 50).ToString();
                    //    p.ReturnPulseTextBox().Text = r.Next(1, 50).ToString();#1#

                    //    //change rpm
                    //    if (!p.ReturnRPM().Focused)
                    //    {
                    //        p.ReturnRPM().Text = pack.RPM.ToString();
                    //    }

                    //    //change time
                    //    if (!p.ReturnTimeTextBox().Focused)
                    //    {
                    //        p.ReturnTimeTextBox().Text = pack.time.ToString();
                    //    }

                    //    //change distance
                    //    if (!p.dis().Focused)
                    //    {
                    //        p.ReturnRPM().Text = pack.RPM.ToString();
                    //    }



                    //        if (!p.ReturnRPM().Focused)
                    //        {
                    //            p.ReturnRPM().Text = pack.RPM.ToString();
                    //        }
                    p.ReturnTimeTextBox().Text = pack.time;
                    p.ReturnPowerTextBox().Text = pack.requestPower;
                    p.ReturnEnergyTextBox().Text = pack.energy.ToString();
                    p.ReturnActualPowerTextBox().Text = pack.actualPower.ToString();
                    p.ReturnPulseTextBox().Text = pack.pulse.ToString();

                    //        string _pulse = pack.pulse.ToString();
                    //        string _rpm = pack.RPM.ToString();
                    //        string _speed = pack.speed.ToString();
                    //        string _distance = pack.distance.ToString();
                    //        string _power = pack.requestPower.ToString();
                    //        string _energy = pack.energy.ToString();
                    //        string _time = pack.time.ToString();
                    //        string _actualPower = pack.actualPower.ToString();


                    //            //Parse all strings to int
                    //            int I_pulse = Int32.Parse(_pulse);
                    //        int I_rpm = Int32.Parse(_rpm);
                    //        int I_speed = Int32.Parse(_speed);
                    //        int I_distance = Int32.Parse(_distance);
                    //        int I_power = Int32.Parse(_power);
                    //        int I_energy = Int32.Parse(_energy);
                    //        TimeSpan ts = TimeSpan.Parse(_time);
                    //        int I_sec = ts.Seconds;
                    //        int I_min = ts.Minutes;
                    //        int I_actualPower = Int32.Parse(_actualPower);

                    //            //Adding coördinates to chart
                    //            MethodInvoker miP = delegate () { p.returnChart().Series["Pulse"].Points.AddXY(I_sec, I_pulse); };
                    //        p.Invoke(miP);
                    //        MethodInvoker miR = delegate () { p.returnChart().Series["Rpm"].Points.AddXY(I_sec, I_rpm); };
                    //        p.Invoke(miR);
                    //        MethodInvoker miS = delegate () { p.returnChart().Series["Speed"].Points.AddXY(I_sec, I_speed); };
                    //        p.Invoke(miS);
                    //        MethodInvoker miD = delegate () { p.returnChart().Series["Distance"].Points.AddXY(I_sec, I_distance); };
                    //        p.Invoke(miD);
                    //        MethodInvoker miPo = delegate () { p.returnChart().Series["Power"].Points.AddXY(I_sec, I_power); };
                    //        p.Invoke(miPo);
                    //        MethodInvoker miE = delegate () { p.returnChart().Series["Energy"].Points.AddXY(I_sec, I_energy); };
                    //        p.Invoke(miE);
                    //        MethodInvoker miAP = delegate () { p.returnChart().Series["ActualPower"].Points.AddXY(I_sec, I_actualPower); };
                    //        p.Invoke(miAP);
                    //        Thread.Sleep(1000);
                    }
                }
                catch
                (Exception)
                {
                    //MessageBox.Show("No connection to the server");
                    form.closeApplicaton();
                }
            }));
        }

        public void Run()
        {
            Random r = new Random();
            while (running)
            {
                Packet packet = (Packet)formatter.Deserialize(form.stream);
                packet.handleMonitorSide(this);
            }
        }
    }
}

