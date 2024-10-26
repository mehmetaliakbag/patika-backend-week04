using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    // Abstract base class for machines
    public abstract class BaseMachine
    {
        // Properties
        public DateTime ProductionDate { get; private set; } // Machine production date
        public string SerialNumber { get; protected set; } // Serial number
        public string Name { get; protected set; } // Machine name
        public string Description { get; protected set; } // Machine description
        public string OperatingSystem { get; protected set; } // Operating system

        // Constructor initializing machine properties
        protected BaseMachine()
        {
            ProductionDate = DateTime.Now; // Set production date to now
        }

        // Abstract method to get product name
        public abstract void GetProductName();

        // Virtual method to print product information
        public virtual void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Set text color
            Console.WriteLine($"\r\nProduction Date: {ProductionDate}" +
                $"\r\nSerial Number: {SerialNumber}" +
                $"\r\nName: {Name}" +
                $"\r\nDescription: {Description}" +
                $"\r\nOperating System: {OperatingSystem}");
        }
    }
}