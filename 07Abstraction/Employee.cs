using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Abstraction
{
    public abstract class Employee
    {
        //Properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }

        //Constructor
        protected Employee(string firstname, string lastname, string department)
        {
            Firstname = firstname;
            Lastname = lastname;
            Department = department;
        }

        //Method
        public abstract void GetInfo();


    }
}
