using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public sealed class Computer : BaseMachine
    {
        private int usbPortCount; // Private field to hold the USB port count

        // Property: USB port count
        public int USBPortCount
        {
            get
            {
                return usbPortCount; // Return the value
            }
            private set
            {
                // Check if the USB port count is valid
                if (value == 2 || value == 4)
                    usbPortCount = value; // Set if valid
                else
                {
                    usbPortCount = -1; // Assign -1 for invalid value
                    Console.WriteLine($"Invalid value range; USB port count can be 2 or 4");
                }
            }
        }

        // Property: Bluetooth status
        public bool HasBluetooth { get; private set; }

        //Constructor
        public Computer() { }


        // Method: Get the product name
        public override void GetProductName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Computer's name  ---> {Name}"); // Print the computer's name
            Console.ResetColor();
        }

        // Method: Print the computer's information
        public override void PrintInfo()
        {
            base.PrintInfo(); // Call the base class's PrintInfo method
            Console.WriteLine($"USB Port Count: {USBPortCount}" + // Print the USB port count
                $"\r\nHas Bluetooth: {HasBluetooth}"); // Print Bluetooth status
            Console.ResetColor();
        }
        // Method to modify the computer details
        public Computer ModifyComputer()
        {
            Computer computer = new Computer();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter information for the phone");

            Console.Write("Serial Number: ");
            computer.SerialNumber = Console.ReadLine();

            Console.Write("Name: ");
            computer.Name = Console.ReadLine();

            Console.Write("Description: ");
            computer.Description = Console.ReadLine();

            Console.Write("Operating System: ");
            computer.OperatingSystem = Console.ReadLine();

            Console.Write("USB Port Count: ");
            computer.USBPortCount = int.Parse(Console.ReadLine());

            Console.Write("Has Bluetooth: ");
            computer.HasBluetooth = bool.Parse(Console.ReadLine());

            Console.ResetColor();

            return computer;

        }
    }
}