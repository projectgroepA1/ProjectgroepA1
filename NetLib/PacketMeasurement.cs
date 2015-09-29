using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    class PacketMeasurement : Packet
    {

        Measurement measurement;
        
        public PacketMeasurement(string RPM, string time, string power, string energy, string AP, string pulse)
        {
            this.measurement = new Measurement(RPM, time, power, energy, AP, pulse);
        }


        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.sendMeasurement(this.measurement);
        }
    }
}
