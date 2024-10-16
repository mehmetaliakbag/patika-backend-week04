using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Polymorphism
{
    public sealed class Square : BaseGeometricShape
    {
        //Constructor
        public Square(double height)
        {
            Height = height;
        }

        //Method
        public override void CalculateArea()
        {
            Console.WriteLine($"Kare'nin Alanı: {Height * Height}");
        }


    }
}
