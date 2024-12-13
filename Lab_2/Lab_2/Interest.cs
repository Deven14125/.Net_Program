using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Interest : Account_Details
    {
        public void CalculateInterest()
        {
            Console.WriteLine("Total Interest Is Given Below ");
            double Interest = (Account_Balance * Year * Interest_Rate) / 100;
            Console.WriteLine("Interest = "+Interest);
        }
    }
}
