using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_delegates
{
    public class BankAccount : IBankAccount
    {
        private decimal balance = 0;
        public decimal credit;
        public delegate void OverdraftEventHandler(decimal overdraftAmount);
        public delegate void BalanceChangedEventHandler(decimal newBalance);

        public event OverdraftEventHandler Overdraft;
        public event BalanceChangedEventHandler BalanceChanged;
        public void Deposit(decimal amount)
        {
            balance+=amount;
            BalanceChanged.Invoke(balance);
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Withdraw(decimal amount)
        {
            if (balance - amount < 0)
            {
                Overdraft.Invoke(-balance+amount);
            }
            else
            {
                balance -= amount;
                BalanceChanged.Invoke(balance);
            }
        }
    }
}
