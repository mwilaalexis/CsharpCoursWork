using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlib
{
   public class GearBox
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public GearBox (int ID, string name)
        {
            this.ID = ID;
            Name = name;
        }
        public GearBox( string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
