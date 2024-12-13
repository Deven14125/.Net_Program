using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class HDFC : RBI
    {
        public override void CalculateInterest()
        {
            double Interest = (Principal * RateInterest * Year) / 100;
            Console.WriteLine("HDFC Bank Interest = " + Interest);
        }
    }
}
