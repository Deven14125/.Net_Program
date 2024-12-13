using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Salary
    {
        public double Basic { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }

        public Salary(double Basic,double TA,double DA = 0.1,double HRA = 0.2)
        {
            this.Basic = Basic;
            this.TA = TA;
            this.DA = DA;
            this.HRA = HRA;
        }

        public void CalculateTotalSalary()
        {
            double TotalSalary = Basic + (Basic * DA) + (Basic * HRA) + TA;
            Console.WriteLine("Total Salary = "+TotalSalary);
        }
    }
}
