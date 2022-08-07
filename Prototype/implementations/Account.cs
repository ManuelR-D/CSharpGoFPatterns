using CSharpGoFPatterns.Prototype.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Prototype.implementations
{
    internal class Account : interfaces.IAccountPrototype
    {
        private string type;
        private double amount;
        private DateTime time;

        public Account(string type, double amount, DateTime time)
        {
            this.type = type;
            this.amount = amount;
            this.time = time;
        }

        public Account ShallowCopy()
        {
            return (Account)this.MemberwiseClone();
        }

        public Account DeepCopy()
        {
            Account clone = this.ShallowCopy();
            clone.type = this.type;
            clone.amount = this.amount;
            clone.time = new DateTime(this.time.Ticks);
            return clone;
        }

        //Clone as prototype.
        public IAccountPrototype clone()
        {
            return (IAccountPrototype)this.Clone();
        }

        public object Clone()
        {
            return this.DeepCopy();
        }
    }
}
