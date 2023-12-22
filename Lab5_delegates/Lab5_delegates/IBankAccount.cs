using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_delegates
{
    public interface IBankAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();


    }
}
