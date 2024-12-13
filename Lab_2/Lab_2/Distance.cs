using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Distance
    {
        public int dist1 { get; set; }
        public int dist2 { get; set; }
        public int dist3 { get; set; }

        public Distance(int dist1,int dist2) 
        { 
            this.dist1 = dist1;
            this.dist2 = dist2;
        }

        public void Addition()
        {
            dist3 = dist1 + dist2;
            Console.WriteLine("Addition  = "+dist3);
        }
    }
}
