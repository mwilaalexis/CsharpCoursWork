using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlib
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Brand(int Id,string name)
        {
            ID = Id;
            Name = name;
        }
        public Brand( string name) 
        {
            
            Name = name;
        }
        public override string ToString()
        {
            return $"{ID} {Name}";
                //$"{ Name }";
        }
    }
}
