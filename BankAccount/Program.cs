using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account userAccount = new Account();
            int userChoice;

            Console.WriteLine("Welcome to 99th Federal Bank of WCCI");

            do
            {
                Console.WriteLine("What can we help you with today?");
                Console.WriteLine("View Client Information, type 1");
                Console.WriteLine("View Account Balance, type 2");
                Console.WriteLine("Deposit Funds, type 3");
                Console.WriteLine("Withdraw Funds, type 4");
                Console.WriteLine("Exit, type 5");

                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        userAccount.ViewInfo();
                        break;
                    case 2:
                        userAccount.ViewBalance();
                        break;
                    case 3:
                        userAccount.DepositFunds();
                        break;
                    case 4:
                        userAccount.WithdrawFunds();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye.");
                        break;
                }
            } while (userChoice <= 4);
        }
    }
}
