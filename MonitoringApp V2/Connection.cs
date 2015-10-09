using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MonitoringApp_V2;

namespace WindowsFormsApplication2
{
    class Connection
    {
        private bool running;
        private DataPanel dataPanel;

        public Connection(DataPanel dataPanel)
        {
            this.dataPanel = dataPanel;
            running = true;
        }

        public void Run()
        {
            Random r = new Random();
            while (running)
            { 
                dataPanel.Invoke((Action)(() =>
                {
                    if (!dataPanel.ReturnRPM().Focused)
                    {
                        dataPanel.ReturnRPM().Text = r.Next(1, 50).ToString();
                    }
                }));
            }
        }
    }
}
