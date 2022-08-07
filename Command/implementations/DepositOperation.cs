using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Command.implementations
{
    internal class DepositOperation : interfaces.IOperation
    {
        private Account a;
        private int amount;
        public DepositOperation(Account a, int amount)
        {
            this.a = a;
            this.amount = amount;
        }
        public void execute()
        {
            this.a.addBalance(this.amount);
        }
    }
}
