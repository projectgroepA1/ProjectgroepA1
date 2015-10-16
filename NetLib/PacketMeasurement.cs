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
        public int pulse { get; }
        public int RPM { get; }
        public int speed { get; }
        public string distance { get; }
        public string requestPower { get; }
        public int energy { get; }
        public string time { get; }
        public int actualPower { get; }

        Measurement measurement;

        public PacketMeasurement(string pulse, string rpm, string speed, string distance, string requestpower, string energy, string time, string actualPower)
        {
            this.measurement = new Measurement(rpm, time, requestpower, energy, actualPower, pulse, speed, distance);
        }

        

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.sendMeasurement(this.measurement);
        }
    }
}
