using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace ServerApp
{
    class ClientHandler
    {
        private TcpClient tc;
        private Server server;
        private DataStorage storage;
        private bool running;

        public ClientHandler(TcpClient tc,Server server)
        {
            this.storage = new DataStorage();
            this.tc = tc;
            this.server = server;
        }

        public void ClientSetUp(Object b)
        {
            while (true)
            {

            }
        }

        public void recieveFromClient()
        {

        }

        /*
        *This method reads the incomming stream, converts it to
        *a Measurement object and gives it to the
        *Datastorage object
        */
        public async void ReadIncommingStream(FileStream stream)
        {
            while (running)
            {



                //after conversion
                storage.AddMeasurement(measurement);

            }
            storage.SaveFile();
        }

    }
}
