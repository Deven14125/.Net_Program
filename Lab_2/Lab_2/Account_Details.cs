using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Account_Details
    {
        public int Account_No { get; set; }
        public string Account_Type { get; set; }
        public double Account_Balance { get; set; }
        public double Interest_Rate { get; set; }
        public int Year { get; set; }

        public void GetAccountDetails()
        {
            Console.Write("Enter Account_No : ");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account_Type : ");
            Account_Type = Console.ReadLine();
            Console.Write("Enter Account_Balance : ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Interest Rate : ");
            Interest_Rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Year : ");
            Year = Convert.ToInt32(Console.ReadLine());
        }
    }
}
