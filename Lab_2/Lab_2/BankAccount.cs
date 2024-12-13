using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class BankAccount
    {
        public int Account_No { get; set; }
        public string Email{ get; set; }
        public string  User_Name { get; set; }
        public string Account_Type { get; set; }
        public double Account_Balance { get; set; }


        public void GetAccountDetails()
        {
            Console.Write("Enter Bank Account No : ");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Bank Email : ");
            Email = Console.ReadLine();
            Console.Write("Enter Bank UserName : ");
            User_Name = Console.ReadLine();
            Console.Write("Enter Bank Account Type : ");
            Account_Type = Console.ReadLine();
            Console.Write("Enter Bank Account Balance : ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Bank Account No = "+Account_No);
            Console.WriteLine("Bank Email = " + Email);
            Console.WriteLine("Bank Username = " + User_Name);
            Console.WriteLine("Bank Account Type = " + Account_Type);
            Console.WriteLine("Bank Account Balance= " + Account_Balance);
        }
    }
}
