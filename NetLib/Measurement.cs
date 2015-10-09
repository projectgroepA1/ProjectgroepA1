using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class Measurement
    {

        private string RPM { get; set; }
        private string time { get; set; }
        private string power { get; set; }
        private string energy { get; set; }
        private string AP { get; set; }
        private string pulse { get; set; }
        private string speed { get; set; }
        private string distance { get; set; }

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
