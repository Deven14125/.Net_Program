using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Addition
    {
        public void Add(int a, int b)
        {
            int ans = a + b;
            Console.WriteLine("Addition int datatype = "+ans);
        }
        public void Add(float a, float b)
        {
            float ans = a + b;
            Console.WriteLine("Addition float datatype = "+ans);
        }

    }
}
