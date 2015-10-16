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
    public class Connection : MonitorInterface
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
            //MessageBox.Show("Yeah new client");
            DataPanel panel = new DataPanel(form,this);
            Client client = new Client(newClient.usename, newClient.counter, panel);
            form.clients.Add(client);
            form.AddPanel(panel);
        }


        public void receiveMeasurement(PacketMonitorMeasurement m)
        {
            Console.WriteLine("Measurement receiced: {0}", m.username + "\t" + m.Id);
            bool name = false;
            bool id = false;

            form.Invoke((Action)(() =>
            {
                try
                {
                    foreach (Client c in form.clients)
                    {
                        Console.WriteLine("Naam: {0}  id: {1}", c.Naam, c.Id);
                        name = c.Naam == m.username;
                        id = c.Id == m.Id;
                        Console.WriteLine("Naam: {0}  id: {1}", name, id);
                       
                        if (c.Naam == m.username && c.Id == m.Id)
                        {
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



                            if (!c.Panel.ReturnRPM().Focused)
                            {
                                c.Panel.ReturnRPM().Text = m.measurement.RPM;
                            }
                            c.Panel.ReturnTimeTextBox().Text = m.measurement.time;
                            c.Panel.ReturnPowerTextBox().Text = m.measurement.power;
                            c.Panel.ReturnEnergyTextBox().Text = m.measurement.energy;
                            c.Panel.ReturnActualPowerTextBox().Text = m.measurement.AP;
                            c.Panel.ReturnPulseTextBox().Text = m.measurement.pulse;

                            string _pulse = m.measurement.pulse;
                            string _rpm = m.measurement.RPM;
                            string _speed = m.measurement.speed;
                            string _distance = m.measurement.distance;
                            string _power = m.measurement.power;
                            string _energy = m.measurement.energy;
                            string _time = m.measurement.time;
                            string _actualPower = m.measurement.AP;


                            //Parse all strings to int
                            int I_pulse = Int32.Parse(_pulse);
                            int I_rpm = Int32.Parse(_rpm);
                            int I_speed = Int32.Parse(_speed);
                            int I_distance = Int32.Parse(_distance);
                            int I_power = Int32.Parse(_power);
                            int I_energy = Int32.Parse(_energy);
                            TimeSpan ts = TimeSpan.Parse(_time);
                            int I_sec = ts.Seconds;
                            int I_min = ts.Minutes;
                            int I_actualPower = Int32.Parse(_actualPower);

                            //Adding coördinates to chart
                            MethodInvoker miP = delegate () { c.Panel.returnChart().Series["Pulse"].Points.AddXY(I_sec, I_pulse); };
                            c.Panel.Invoke(miP);
                            MethodInvoker miR = delegate () { c.Panel.returnChart().Series["RPM"].Points.AddXY(I_sec, I_rpm); };
                            c.Panel.Invoke(miR);
                            MethodInvoker miS = delegate () { c.Panel.returnChart().Series["Speed"].Points.AddXY(I_sec, I_speed); };
                            c.Panel.Invoke(miS);
                            MethodInvoker miD = delegate () { c.Panel.returnChart().Series["Distance"].Points.AddXY(I_sec, I_distance); };
                            c.Panel.Invoke(miD);
                            MethodInvoker miPo = delegate () { c.Panel.returnChart().Series["Power"].Points.AddXY(I_sec, I_power); };
                            c.Panel.Invoke(miPo);
                            MethodInvoker miE = delegate () { c.Panel.returnChart().Series["Energy"].Points.AddXY(I_sec, I_energy); };
                            c.Panel.Invoke(miE);
                            MethodInvoker miAP = delegate () { c.Panel.returnChart().Series["Actual Power"].Points.AddXY(I_sec, I_actualPower); };
                            c.Panel.Invoke(miAP);
                            
                            break;
                        }
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

        public void writePacket(Packet packet)
        {
            //Insert body here
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

