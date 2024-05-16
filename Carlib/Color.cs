using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Carlib
{
    public class Color
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Color(int Id,string name)
        {
            ID = Id;
            Name = name;
        }
        public Color (string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
