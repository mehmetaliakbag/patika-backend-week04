using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Inheritance
{
    public class Teacher : Person
    {

        // Additional Property
        public double Salary { get; set; }

        // Add Constructor
        public Teacher(string firstName, string lastName, double salary)
            : base(firstName, lastName)
        {
            Salary = salary; // New Field
        }

        // Implementing the abstract method
        public override void PrintInfo()
        {
            Console.WriteLine($"Salary: {Salary}, First Name: {FirstName}, Last Name: {LastName}");
        }

    }
}
