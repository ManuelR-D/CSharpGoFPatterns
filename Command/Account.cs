using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Command
{
    internal class Account
    {
        private int balance;

        public int getBalance()
        {
            return balance;
        }

        public void reduceBalance(int amount)
        {
            this.balance -= amount;
        }

        internal void addBalance(int amount)
        {
            this.balance += amount;
        }
    }
}
