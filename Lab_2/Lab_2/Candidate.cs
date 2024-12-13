using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Candidate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public void GetCandidateDetails()
        {
            Console.Write("Enter Candidate ID : ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Candidate Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Candidate Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Candidate Weight : ");
            Weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Candidate Height : ");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("User Entered Data Is Given Below");
            Console.WriteLine("Candidate ID : " + ID);
            Console.WriteLine("Candidate Name : " + Name);
            Console.WriteLine("Candidate Age : " + Age);
            Console.WriteLine("Candidate Weight : " + Weight);
            Console.WriteLine("Candidate Height : " + Height);
        }
    }
}
