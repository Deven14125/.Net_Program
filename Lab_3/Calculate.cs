using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Calculate : Sum
    {

        public override void SumOfTwo(int a, int b)
        {
            int answer = a + b;
            Console.WriteLine("Sum Of Two Numbers = "+answer);
        }
        public override void SumOfThree(int a, int b, int c)
        {
            int answer = a + b + c;
            Console.WriteLine("Sum Of Three Numbers = " + answer);
        }
    }
}
