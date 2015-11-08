using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
    [Serializable]
    public class Identifier
    {
        public string Username { get; set; }
        public int Id { get; }

        public Identifier(string username, int Id)
        {
            Username = username;
            this.Id = Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is Identifier)
            {
                Identifier id2 = obj as Identifier;
                if (Username == id2.Username && Id == id2.Id)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
