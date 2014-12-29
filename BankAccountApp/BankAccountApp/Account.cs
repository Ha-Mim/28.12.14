using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Account
    {
        public string AccountNo { set; get; }
        public string OpeningDate { set; get; }
        public double Balance { private set; get; }

        public double Deposit(double amount)
        {
            return Balance += amount;
        }

        public double Withdraw(double amount)
        {
            return Balance -= amount;
        }
    }
}
