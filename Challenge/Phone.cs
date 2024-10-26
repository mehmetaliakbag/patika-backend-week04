using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public sealed class Phone : BaseMachine
    {
        // Property to indicate if the phone has a Turkish license
        public bool TurkishLicensedStatus { get; private set; }

        //Constructor
        public Phone() { }
        // Method to get the product name
        public override void GetProductName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Phone's name  ---> {Name}");
            Console.ResetColor();
        }

        // Method to print the phone's information
        public override void PrintInfo()
        {
            base.PrintInfo(); // Call the base class PrintInfo
            Console.WriteLine($"Has Licence: {TurkishLicensedStatus}");
            Console.ResetColor();
        }

        // Method to modify the phone details
        public Phone ModifyPhone()
        {
            Phone phone = new Phone();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter information for the phone");

            Console.Write("Serial Number: ");
            phone.SerialNumber = Console.ReadLine();

            Console.Write("Name: ");
            phone.Name = Console.ReadLine();

            Console.Write("Description: ");
            phone.Description = Console.ReadLine();

            Console.Write("Operating System: ");
            phone.OperatingSystem = Console.ReadLine();

            Console.Write("TR Licensed (true/false): ");
            phone.TurkishLicensedStatus = bool.Parse(Console.ReadLine());

            Console.ResetColor();

            return phone;

        }
    }
}