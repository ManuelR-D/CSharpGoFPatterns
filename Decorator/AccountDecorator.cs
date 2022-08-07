using CSharpGoFPatterns.Decorator.interfaces;
using CSharpGoFPatterns.Decorator.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Decorator
{
    internal abstract class AccountDecorator : interfaces.IBankAccount
    {
        protected interfaces.IBankAccount decoratedAccount;

        public AccountDecorator(IBankAccount decoratedAccount)
        {
            this.decoratedAccount = decoratedAccount;
        }

        public virtual void openAccount(Account a)
        {
            this.openAccount(a);
        }
    }
}
