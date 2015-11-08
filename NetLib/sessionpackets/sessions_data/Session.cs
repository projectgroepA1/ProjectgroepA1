using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib.sessionpackets.sessions_data
{
    [Serializable]
    public class Session
    {
        public List<Tuple<int, int, int, int, int, int, int>> data { get; }

        public string username { get; }


        public int ID { get; set; }

        public Session(List<Tuple<int, int, int, int, int, int, int>> list, string username)
        {
            this.data = list;
            this.username = username;
        }

        public override string ToString()
        {
            return username + ID;
        }
    }
}
