using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlib
{
   public class Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public  Brand Brand { get; set; }
        public string Image = "D:\\BestSale\\BestSale\\img\\sports-car-races-through-dark-blurred-motion-generative-ai.png";  

        public Model(int ID, string name,Brand brand)
        {
            this.ID = ID;
            this.Name = name;
            Brand = brand;
        }
        public Model( string name, Brand brand) 
        {
            Name = name;
            this.Brand = brand;
        }
        public override string ToString()
        {
            return $"{ID}   {Name}   {Brand.Name}";
        }
    }
}
