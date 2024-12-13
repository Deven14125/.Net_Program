using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class BankAccount
    {
        public double accountBalance { get; set; }
        public string AccountholderName { get; set; }
        public BankAccount(double accountBalance,string AccountholderName)
        { 
            this.accountBalance = accountBalance;
            this.AccountholderName = AccountholderName;
        }

        public void Deposit()
        {
            Console.WriteLine("Welcome To Deposit System Where You Can Deposit Cash By Tapping On Screen Digitally:");
            Console.Write("Do you want to deposit cash in your account? (yes/no): ");

            string input = Console.ReadLine().ToLower();  
            bool isDeposit = input == "yes" || input == "y"; 

            double deposit = 0;

            if (isDeposit)
            {
                Console.Write("Enter the amount you want to deposit in your account: ");
                deposit = Convert.ToDouble(Console.ReadLine());
                double totalBalance = accountBalance + deposit;
                Console.WriteLine("Your updated balance = " + totalBalance);
            }
            else
            {
                Console.WriteLine("Your current balance: " + accountBalance);
            }
        }


        public void Withdraw()
        {
            Console.Write("Do you want to Withdraw cash From your account? (yes/no): ");

            string input = Console.ReadLine().ToLower();
            bool isWithdraw = input == "yes" || input == "y";

            double Withdraw = 0;

            if (isWithdraw)
            {
                Console.Write("Enter the amount you want to deposit in your account: ");
                Withdraw = Convert.ToDouble(Console.ReadLine());
                double TotalBalance = accountBalance - Withdraw;
                Console.WriteLine("Your Balance After Withdraw = " + TotalBalance);
            }
            else
            {
                Console.WriteLine("Your Current Balance: " + accountBalance);
            }
        }
    }
}
