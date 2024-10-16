using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Polymorphism
{
    public abstract class BaseGeometricShape
    {

        //Properties
        public double Height { get; set; }

        public double Width { get; set; }

        //Constructor       
        //public BaseGeometricShape(double height, double width)
        //{
        //    Height = height;
        //    Width = width;
        //}

        //Method
        public abstract void CalculateArea();

    }
}
