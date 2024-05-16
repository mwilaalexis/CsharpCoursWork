using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlib
{
    public class Customer
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Customer(int id, string firstName, string lastName)
        {
            this.Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public Customer( string firstName, string lastName)
        {
            
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
