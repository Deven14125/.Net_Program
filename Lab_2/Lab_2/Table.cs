using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Table : Furniture
    {
        public double Height { get; set; }
        public double Surface_Area { get; set; }

        public void GetTableDetails()
        {
            Console.Write("Enter Table Height : ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Table Surface_Area : ");
            Surface_Area = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAllDetails()
        {
            Console.WriteLine("All Details Given Below");
            Console.WriteLine("Table Furniture Type : "+Material);
            Console.WriteLine("Table Furniture Price : " + Price);
            Console.WriteLine("Table Furniture Height : " + Height);
            Console.WriteLine("Table Furniture Surface_Area : " + Surface_Area);
        }
    }
}
