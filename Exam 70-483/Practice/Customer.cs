using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Customer : Person
    {
        public string PIN { get; set; }

        public Customer(string firstName)
            : base(firstName)
        {

        }

        public Customer(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        public Customer(string firstName, string lastName, string pin)
            : base(firstName, lastName)
        {
            PIN = pin;
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, name: {1}, pin: {2}", this.GetType(), this.FullName(), this.PIN);
        }
    }
}