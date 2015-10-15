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
        //public int pulse { get; }
        //public int RPM { get; }
        //public int speed { get; }
        //public string distance { get; }
        //public string requestPower { get; }
        //public int energy { get; }
        //public string time { get; }
        //public int actualPower { get; }

        Measurement measurement;
        
        public PacketMeasurement(string pulse, string rpm, string speed, string distance, string requestpower, string energy,string time, string actualPower)
        {
            this.measurement = new Measurement(rpm, time, requestpower, energy, actualPower, pulse,speed,distance);
        }

        //public PacketMeasurement(int pulse, int rpm, int speed, string distance, string requestPower, int energy, string time, int actualPower)
        //{
        //    this.pulse = pulse;
        //    this.RPM = rpm;
        //    this.speed = speed;
        //    this.distance = distance;
        //    this.requestPower = requestPower;
        //    this.energy = energy;
        //    this.time = time;
        //    this.actualPower = actualPower;
        //}

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.sendMeasurement(this.measurement);
        }
    }
}
