using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            while (running)
            {
                if (!form.ReturnRPM().Focused)
                {
                    //update rpm data van server
                    form.ReturnRPM().Text = "test";
                }
                else if (form.ReturnRPM().Modified)
                {
                    string RPM = form.ReturnRPM().Text;
                    //verzend rpm naar server
                }
                //haal data van server op en weergeef het
            }
        }
    }
}
