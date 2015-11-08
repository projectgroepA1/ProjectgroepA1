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

        public string RPM { get;  }
        public string time { get;  }
        public string power { get;  }
        public string energy { get;  }
        public string AP { get;  }
        public string pulse { get;  }
        public string speed { get;  }
        public string distance { get;  }

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
