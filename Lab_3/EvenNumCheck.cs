using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class EvenNumCheck
    {
        public int Num { get; set; }

        public void GetNum()
        {
            Console.Write("Enter a Number : ");
            Num = Convert.ToInt32(Console.ReadLine());
        }

        public void CheckEvenOrNot()
        {
            if (Num%2==0)
            {
                Console.WriteLine("Number IS Even : "+Num);
            }
        }
    }
}
