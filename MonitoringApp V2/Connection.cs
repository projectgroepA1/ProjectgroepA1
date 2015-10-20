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
            //MessageBox.Show("Yeah new client: "+newClient.GetHashCode());

            DataPanel panel = new DataPanel(form,this, newClient.Identifier);
            Client client = new Client(newClient.Identifier, panel);

            form.clients.Add(client);
            form.AddPanel(panel);
        }

        public void recieveChat(PacketChat pack)
        {
            Console.WriteLine("Recieved Chat Packet");

            form.Invoke((Action)(() =>
            {
                try
                {
                form.showMessage(pack.destinationID, pack.messageText);
                }
                catch
                (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //MessageBox.Show("No connection to the server");
                    //form.closeApplicaton();
                }
            }));
        }


        public void receiveMeasurement(PacketMonitorMeasurement m)
        {
            Console.WriteLine("Measurement receiced: {0}", m.identifier.Username + "\t" + m.identifier.Id);
            
            form.Invoke((Action)(() =>
            {
                try
                {
                    //Console.WriteLine("Amount of cliens: "+form.clients);
                    foreach (Client c in form.clients)
                    {
                        Console.WriteLine("Naam: {0}  id: {1}", c.Identifier.Username, c.Identifier.Id);
                        ;
                        Console.WriteLine("Same? {0}", c.Identifier.Equals(m.identifier));
                       
                        if (c.Identifier.Equals(m.identifier))
                        {
                            if (!c.Panel.ReturnRPM().Focused)
                            {
                                c.Panel.ReturnRPM().Text = m.measurement.RPM;
                            }
                            c.Panel.ReturnTimeTextBox().Text = m.measurement.time;
                            c.Panel.ReturnPowerTextBox().Text = m.measurement.power;
                            c.Panel.ReturnEnergyTextBox().Text = m.measurement.energy;
                            c.Panel.ReturnActualPowerTextBox().Text = m.measurement.AP;
                            c.Panel.ReturnPulseTextBox().Text = m.measurement.pulse;
                            c.Panel.ReturnDistanceTextBox().Text = m.measurement.distance;

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
                (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //MessageBox.Show("No connection to the server");
                    //form.closeApplicaton();
                }
            }));
        }

        public void writePacket(Packet packet)
        {
            formatter = new BinaryFormatter();
            formatter.Serialize(this.form.Client.GetStream(), packet);
        }

        public void Run()
        {
            Random r = new Random();
            while (running)
            {
                Packet packet = (Packet)formatter.Deserialize(form.Client.GetStream());
                packet.handleMonitorSide(this);
            }
        }
    }
}

