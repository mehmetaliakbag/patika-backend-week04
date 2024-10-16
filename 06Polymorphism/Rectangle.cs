using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Polymorphism
{
    public sealed class Rectangle : BaseGeometricShape
    {

        //Constructor
        public Rectangle(double width, double height)
        {
            Height = height;
            Width = width;
        }

        //Method
        public override void CalculateArea()
        {
            Console.WriteLine($"Dikdörtgenin Alanı: {Width * Height}");
        }

    }
}
