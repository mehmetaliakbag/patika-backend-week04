using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Inheritance
{

    public abstract class Person
    {

        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor
        protected Person(string firstName, string lastName)
        {
            FirstName = firstName;

        }

        // Abstract method to print information
        public abstract void PrintInfo();

    }
}
