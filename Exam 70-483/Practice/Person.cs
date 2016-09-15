using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Person : IEquatable<Person>, IPrintable
    {
        public delegate int CalculateAge(int yearBorn);

        public CalculateAge calculateAge;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName)
        {
            this.FirstName = firstName;
        }

        public Person(string firstName, string lastName)
            : this(firstName)
        {
            this.LastName = lastName;
        }

        public Person(string firstName, string lastName, int yearBorn)
            : this(firstName, lastName)
        {
            calculateAge = CalcAge;
            this.Age = calculateAge(yearBorn);
        }

        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public bool Equals(Person other)
        {
            return ((FirstName == other.FirstName) && (LastName == other.LastName));
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public int CalcAge(int yearBorn)
        {
            return DateTime.Now.Year - yearBorn;
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} {2} old.", this.FullName(), this.Age, this.Age > 1 ? "years" : "year");
        }
    }
}