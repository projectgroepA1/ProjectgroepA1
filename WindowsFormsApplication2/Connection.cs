using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NetLib;

namespace WindowsFormsApplication2
{
    class Connection : ClientInterface
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
            //Random r = new Random();
            //while (running)
            //{ 
            //    form.Invoke((Action)(() =>
            //    {
            //        if (!form.ReturnRPM().Focused && running)
            //        {
            //            form.ReturnRPM().Text = r.Next(1, 50).ToString();
            //        }
            //    }));
            //}
        }

        public void loginResponse(bool loginOk)
        {
            
        }

        public void recieveResponse(bool recieveOk)
        {
            
        }

        public void disconnectResponse(bool disconnectOk)
        {
            
        }

        public void receivePacketChat(PacketChat chat)
        {
            
        }

        public void recievePacketChat(PacketChat chat)
        {
            
        }

        public void recievePacketBicycleCommand(PacketBicycleCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
