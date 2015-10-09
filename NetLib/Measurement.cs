using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    public class Measurement
    {
        protected string RPM { get; set; }
        protected string time { get; set; }
        protected string power { get; set; }
        protected string energy { get; set; }
        protected string AP { get; set; }
        public string pulse { get; set; }
        protected string speed { get; set; }
        public string distance { get; set; }

        public Measurement(string RPM, string time, string power, string energy, string AP, string pulse,string speed,string distance)
        {
            this.RPM = RPM;
            this.time = time;
            this.power = power;
            this.energy = energy;
            this.AP = AP;
            this.pulse = pulse;
            this.speed = speed;
            this.distance = distance;
        }
    }
}
