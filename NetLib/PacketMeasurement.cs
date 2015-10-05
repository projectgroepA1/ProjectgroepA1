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

<<<<<<< HEAD
        Measurement measurement;
        
        public PacketMeasurement(string RPM, string time, string power, string energy, string AP, string pulse)
        {
            this.measurement = new Measurement(RPM, time, power, energy, AP, pulse);
        }

=======
        public PacketMeasurement(int pulse, int rpm, int speed, string distance, string requestPower, int energy, string time, int actualPower)
        {
            this.pulse = pulse;
            this.RPM = rpm;
            this.speed = speed;
            this.distance = distance;
            this.requestPower = requestPower;
            this.energy = energy;
            this.time = time;
            this.actualPower = actualPower;
        }
>>>>>>> Client-Jeroen-

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.sendMeasurement(this.measurement);
        }
    }
}
