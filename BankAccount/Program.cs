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
            ClientInfo userInfo = new ClientInfo("Ben", "Klein", 1560, "Saint Charles Ave", "Lakewood", "OH", 44107);
            CheckingAccount userChecking = new CheckingAccount(1234, 10000.99);
            SavingsAccount userSavings = new SavingsAccount(5678, 25000.89);

            int userChoice;
            char userChoice2;
            
            Console.WriteLine("Welcome to 99th Federal Bank of WCCI");
            Console.WriteLine("");

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
                        userInfo.ViewInfo();
                        break;
                    case 2:
                         Console.WriteLine("Which account balance do you wish to check?");
                         Console.WriteLine("Type C for checking");
                         Console.WriteLine("Type S for savings");

                            userChoice2 = char.Parse(Console.ReadLine().ToUpper());

                            if (userChoice2 == 'C')
                            {
                                userChecking.ViewBalance();//does it know which subclass method to call?
                                break;
                            }
                            else if (userChoice2 == 'S')
                            {
                                userSavings.ViewBalance();
                                break;
                            }
                            else
                            {
                            break;
                            }
                    case 3:
                        Console.WriteLine("Which account do you wish to deposit funds to?");
                        Console.WriteLine("Type C for checking");
                        Console.WriteLine("Type S for savings");

                        userChoice2 = char.Parse(Console.ReadLine().ToUpper());

                        if (userChoice2 == 'C')
                        {
                            userChecking.DepositFunds();
                            break;
                        }
                        else if (userChoice2 == 'S')
                        {
                            userSavings.DepositFunds();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case 4:
                        Console.WriteLine("Which account do you wish to withdraw funds from?");
                        Console.WriteLine("Type C for checking");
                        Console.WriteLine("Type S for savings");

                        userChoice2 = char.Parse(Console.ReadLine().ToUpper());

                        if (userChoice2 == 'C')
                        {
                            userChecking.WithdrawFunds();
                            break;
                        }
                        else if (userChoice2 == 'S')
                        {
                            userSavings.WithdrawFunds();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case 5:
                        Console.WriteLine("Goodbye.");
                        break;
                }
            } while (userChoice <= 4);
        }
    }
}
