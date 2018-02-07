using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingsAccount : AccountsOverview
    {
        //fields
        //invisible

        //Properties
        public int SavingsAcctNumber { get; set; }
        public double SavingsBalance { get; set; }
        public double SavingsDepositAmount { get; set; }
        public double SavingsWithdrawAmount { get; set; }

        //Constructors
        public SavingsAccount()
        {
            //default constructor
        }

        public SavingsAccount(int savingsAcctNumber, double savingsBalance)
        {
            SavingsAcctNumber = savingsAcctNumber;
            SavingsBalance = savingsBalance;
        }

        //Methods

        public override void ViewBalance()
        {
            Console.WriteLine("Your current balance is $" + SavingsBalance);
        }

        public override void DepositFunds()
        {
            Console.WriteLine("How much would you like to deposit into your Savings Account?");
            SavingsDepositAmount = double.Parse(Console.ReadLine());
            SavingsBalance = SavingsDepositAmount + SavingsBalance;
            Console.WriteLine("Your new Savings Account balance is $" + SavingsBalance);
        }

        public override void WithdrawFunds()
        {
            Console.WriteLine("How much would you like to withdraw from your Savings Account?");
            SavingsWithdrawAmount = double.Parse(Console.ReadLine());
            if (SavingsBalance >= SavingsWithdrawAmount)
            {
                SavingsBalance = SavingsBalance - SavingsWithdrawAmount;
                Console.WriteLine("Your new Savings Account balance is $" + SavingsBalance);
            }
            else
            {
                Console.WriteLine("You have insufficient funds in your Savings Account.");
            }
        }
    }
}
