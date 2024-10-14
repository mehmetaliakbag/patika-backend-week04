using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SchoolManagementSystem
{
    public class Person
    {
        //Fields
        private string name;
        private string surname;
        private DateTime dateOfBirth;

        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }

        }

        public DateTime DateOfBirth

        {
            get
            {
                return DateOfBirth;
            }

            set
            {
                if (value <= DateTime.Now) ;
            }
        }
   

     

        //Method
        public void GetPersonDetails()
        {
            Console.WriteLine($"Adı: {name}" +
                              $"\r\nSoyadı: {surname}" +
                              $"\r\nDoğum Tarihi: {dateOfBirth}");
        }


    }

}