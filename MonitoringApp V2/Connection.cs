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
    class Connection
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

        public void Run()
        {
            Random r = new Random();
            while (running)
            { 
                form.Invoke((Action)(() =>
                {
                    try
                    {
                        PacketMeasurement pack = (PacketMeasurement) formatter.Deserialize(form.stream);
                        foreach (DataPanel p in form.panels)
                        {
                            if (!p.ReturnRPM().Focused)
                            {
                                p.ReturnRPM().Text = r.Next(1, 50).ToString();
                            }
                            p.ReturnTimeTextBox().Text = r.Next(1, 50).ToString();
                            p.ReturnPowerTextBox().Text = r.Next(1, 50).ToString();
                            p.ReturnEnergyTextBox().Text = r.Next(1, 50).ToString();
                            p.ReturnActualPowerTextBox().Text = r.Next(1, 50).ToString();
                            p.ReturnPulseTextBox().Text = r.Next(1, 50).ToString();
 /*                           if (!p.ReturnRPM().Focused)
                            {
                                p.ReturnRPM().Text = pack.RPM.ToString();
                            }
                            p.ReturnTimeTextBox().Text = pack.time;
                            p.returnPowerTextBox().Text = pack.requestPower;
                            p.returnEnergyTextBox().Text = pack.energy.ToString();
                            p.returnActualPowerTextBox().Text = pack.actualPower.ToString();
                            p.returnPulseTextBox().Text = pack.pulse.ToString();
                            Thread.Sleep(1000);*/
                        }
                    }
                    catch
                    (Exception)
                    {
                        MessageBox.Show("No connection to the server");
                        form.closeApplicaton();
                    }
                }));
            }
        }
    }
}
