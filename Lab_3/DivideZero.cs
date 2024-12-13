 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class DivideZero
    {
        public int Num { get; set; }

        public void GetNumber()
        {
            Console.Write("Enter a Number : ");
            Num = Convert.ToInt32(Console.ReadLine());
        }
        public void DivideByZero()
        {
            Console.Write("Enter Divider : ");
            int divider = Convert.ToInt32(Console.ReadLine());
            int answer = Num/divider;
            Console.WriteLine("Answer is : "+answer);
        }
    }
}
