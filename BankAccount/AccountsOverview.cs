using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class AccountsOverview
    {
        //fields
        //invisible

        //Properties
                
        //Constructors
        public AccountsOverview()
        {
            //default constructor
        }

        //Methods
        public abstract void ViewBalance();

        public abstract void WithdrawFunds();

        public abstract void DepositFunds();
        
            
        
    }
}
