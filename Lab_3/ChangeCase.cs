using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class ChangeCase
    {
        public char Character { get; set; } 

        public void GetChar()
        {
            Console.Write("Enter Character : ");
            Character = char.Parse(Console.ReadLine());
        }

        public void Changecase()
        {
            Console.WriteLine("To LowerCase : "+Character.ToString().ToLower());
            Console.WriteLine("To UpperCase : " + Character.ToString().ToUpper());
        }
    }
}
