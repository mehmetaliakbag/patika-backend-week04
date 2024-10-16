using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Inheritance
{
    public class Student : Person
    {

        // Add Property

        public string StudentNumber {  get; set; }

        // Add Constructor
        public Student(string firstname, string lastname, string studentNumber)
            :base(firstname, lastname)
        {
            StudentNumber = studentNumber; // New Field
        }

        // Implementing the abstract method
        public override void PrintInfo()
        {
            Console.WriteLine($"Student Number: {StudentNumber}, First Name: {FirstName}, Last Name: {LastName}");
        }

    }
}
