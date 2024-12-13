using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class LowerUpper
    {
        public string Name { get; set; }

        public void GetDetail()
        {
            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();
        }

        public void ToLowerCase()
        {
            Console.WriteLine("LowerCase = "+Name.ToLower());
        }

        public void ToUpperCase()
        {
            Console.WriteLine("LowerCase = " + Name.ToUpper());
        }
    }
}
