using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class AreaCalculate : Shape
    {
        public void Circle(double radius)
        {
            double area = radius * radius * Math.PI;
            Console.WriteLine("Area Of Circle = " + area);
        }

        public void Square(double length)
        {
            double area = length * length * length;
            Console.WriteLine("Area Of Square = " + area);
        }

        public void Triangle(double length, double Base)
        {
            double area = (0.5)*(length*Base);
            //double area1 = (1/2) * (length * Base);
            Console.WriteLine("Area Of Triangle = " + area);
        }
    }
}
