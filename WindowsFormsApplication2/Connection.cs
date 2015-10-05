using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
                    if (!form.ReturnRPM().Focused)
                    {
                        form.ReturnRPM().Text = r.Next(1, 50).ToString();
                    }
                }));
            }
        }
    }
}
