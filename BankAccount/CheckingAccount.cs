using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CheckingAccount : AccountsOverview
    {
        //fields
        //invisible

        //Properties
        public int CheckingAcctNumber { get; set; }
        public double CheckingBalance { get; set; }
        public double CheckingDepositAmount { get; set; }
        public double CheckingWithdrawAmount { get; set; }

        //Constructors
        public CheckingAccount()
        {
            //default constructor
        }

        public CheckingAccount(int checkingAcctNumber, double checkingBalance)
        {
            CheckingAcctNumber = checkingAcctNumber;
            CheckingBalance = checkingBalance;
        }

        //Methods

        public override void ViewBalance()
        {
            Console.WriteLine("Your current balance is $" + CheckingBalance);
        }

        public override void DepositFunds()
        {
            Console.WriteLine("How much would you like to deposit into your Checking Account?");
            CheckingDepositAmount = double.Parse(Console.ReadLine());
            CheckingBalance = CheckingDepositAmount + CheckingBalance;
            Console.WriteLine("Your new Checking Account balance is $" + CheckingBalance);
        }

        public override void WithdrawFunds()
        {
            Console.WriteLine("How much would you like to withdraw from your Checking Account?");
            CheckingWithdrawAmount = double.Parse(Console.ReadLine());
            if (CheckingBalance >= CheckingWithdrawAmount)
            {
                CheckingBalance = CheckingBalance - CheckingWithdrawAmount;
                Console.WriteLine("Your new Checking Account balance is $" + CheckingBalance);
            }
            else
            {
                Console.WriteLine("You have insufficient funds in your Checking Account.");
            }
        }



    }
    
    }

