using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Area
    {
        public void area(int side)
        {
            int areaSq = side*side;
            Console.WriteLine("Area Of Square = "+areaSq);
        }
        public void area(double length,double width)
        {
            double areaRe = length*width;
            Console.WriteLine("Area Of Square = " + areaRe);
        }
    }
}
