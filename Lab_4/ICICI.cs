using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class ICICI : RBI
    {
        public override void CalculateInterest()
        {
            double Interest = (Principal * RateInterest * Year) / 100;
            Console.WriteLine("ICICI Bank Interest = " + Interest);
        }
    }
}
