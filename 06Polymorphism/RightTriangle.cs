using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Polymorphism
{
     public sealed class RightTriangle : BaseGeometricShape
    {

        //Constructor
        public RightTriangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        //Method
        public override void CalculateArea()
        {
            Console.WriteLine($"Dik Üçgenin Alanı: {(Height * Width) / 2}");
        }

    }
}
