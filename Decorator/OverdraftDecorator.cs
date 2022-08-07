using CSharpGoFPatterns.Decorator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Decorator
{
    internal class OverdraftDecorator : AccountDecorator
    {
        private int overdraftAmount = 0;
        public OverdraftDecorator(IBankAccount decoratedAccount, int overdraftAmount) : base(decoratedAccount)
        {
            this.overdraftAmount = overdraftAmount;
        }
        public override void openAccount(model.Account a)
        {
            this.decoratedAccount.openAccount(a);
            if(this.overdraftAmount == 0)
            {
                this.setDefaultOverdraft();
            }
        }

        private void setDefaultOverdraft()
        {
            this.overdraftAmount = 100;
        }
    }
}
