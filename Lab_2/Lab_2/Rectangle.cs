using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double Height,double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public void Area()
        {
            double area = Height*Width; 
            Console.WriteLine("Area Of Rectangle = "+area);
        }
    }
}
