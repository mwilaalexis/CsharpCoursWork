using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlib
{
    public class BodyType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public BodyType(int id,string name)
        {
            ID = id;
            this.Name = name;
        }
        public BodyType( string name)
        {
            this.Name= name;
        }
        public override string ToString()
        {
            return $"{ID}{Name}\n";
        }
    }
}
