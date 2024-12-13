using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Staff
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }

        //Staff[] staff = new Staff[2];

        public void GetStaffDetails()
        {
            Console.Write("Enter Name of Staff : ");
            string Name = Console.ReadLine();
            Console.Write("Enter Department of Staff : ");
            string Department = Console.ReadLine();
            Console.Write("Enter Designation of Staff : ");
            string Designation = Console.ReadLine();
            Console.Write("Enter Experience of Staff : ");
            int Experience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary of Staff : ");
            double Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetail()
        {
            Console.WriteLine("Staff Name = " + Name);
            Console.WriteLine("Staff Department = " + Department);
            Console.WriteLine("Staff Designation = " + Designation);
            Console.WriteLine("Staff Experience = " + Experience);
            Console.WriteLine("Staff Salary = " + Salary);
        }
    }
}
