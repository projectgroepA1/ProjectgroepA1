﻿using System;
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
        private Form1 form;

        public Connection(Form1 form)
        {
            this.form = form;
            running = true;
        }

        public void Run()
        {
            Random r = new Random();
            while (running)
            { 
                form.Invoke((Action)(() =>
                {
                    foreach (DataPanel p in form.panels)
                    {
                        if (!p.ReturnRPM().Focused)
                        {
                            p.ReturnRPM().Text = r.Next(1, 50).ToString();
                        }
                    }
                }));
            }
        }
    }
}