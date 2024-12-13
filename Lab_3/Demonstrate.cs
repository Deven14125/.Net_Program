using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Demonstrate
    {
        public int Num { get; set; }

        public void ReadnNumber()
        {
            Console.Write("Enter A Number : ");
            Num = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowNumber()
        {
            Console.WriteLine("Num = "+Num);
        }
    }
}
