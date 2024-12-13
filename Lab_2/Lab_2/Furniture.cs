using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Furniture
    {
        public string Material { get; set; }
        public int Price { get; set; }

        public void GetFurnitureDetails()
        {
            Console.Write("Enter Furniture Material Type : ");
            Material = Console.ReadLine();
            Console.Write("Enter Furniture Price : ");
            Price = Convert.ToInt32(Console.ReadLine());
        }
    }
}
