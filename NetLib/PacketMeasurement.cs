using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class PacketMeasurement : Packet
    {
        public Measurement measurement { get; }

        public PacketMeasurement(string pulse, string rpm, string speed, string distance, string requestpower, string energy, string time, string actualPower)
        {
            measurement = new Measurement(rpm, time, requestpower, energy, actualPower, pulse, speed, distance);
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.sendMeasurement(this);
        }
    }
}
