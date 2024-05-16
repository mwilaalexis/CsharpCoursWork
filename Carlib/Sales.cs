using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlib
{
    public class Sales
    {
        public int Id { get; set; }
        public CarInfo Car { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public Sales(int Id,CarInfo car, decimal price, DateTime date, Customer customer)
        {
            this.Id = Id;
            Car = car;
            Price = price;
            Date = date;
            Customer = customer;
        }
        public Sales( CarInfo car, decimal price, DateTime date, Customer customer)
        {
            
            Car = car;
            Price = price;
            Date = date;
            Customer = customer;
        }

        public override string  ToString()
        {
            return $"congratulation {Customer.FirstName} buy a {Car.Color} {Car.Model.Brand.Name} at {Price}";
        }
    }
}

