using CSharpGoFPatterns.Decorator.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Decorator.implementations
{
    internal class CheckingAccount : interfaces.IBankAccount
    {
        public void openAccount(Account a)
        {
            throw new NotImplementedException();
        }
    }
}
