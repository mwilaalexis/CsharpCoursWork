using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Carlib
{
    public class CarInfo
    {
        public int id { get; set; }
        public Model Model { get; set; }
        public Color Color { get; set; }
        public  BodyType Body{ get; set; }
        public double mileage { get; set; }
        public DateTime FabDate { get; set; }
        public decimal Cost { get; set; }
        public GearBox GearBox { get; set; }
       // public Image Image { get; set; }
        public CarInfo(int Id,Model model, Color color, BodyType body, double mileage, DateTime fabDate, decimal cost, GearBox gearBox)
        {
            id = Id;
            Model = model;
            Color = color;
            Body = body;
            this.mileage = mileage;
            FabDate = fabDate;
            Cost = cost;
            GearBox = gearBox;
        }

        public CarInfo( Model model, Color color, BodyType body, double mileage, DateTime fabDate, decimal cost, GearBox gearBox)
        {
            
            Model = model;
            Color = color;
            Body = body;
            this.mileage = mileage;
            FabDate = fabDate;
            Cost = cost;
            GearBox = gearBox;
        }

        public override string ToString()
        {
            return $"{Model.Brand.Name}\t{Color.Name}\t{ Model.Name}\t{GearBox}\t{Cost}\t{mileage}\t{FabDate}\n ";
        }


    }
}
