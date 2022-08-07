using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Prototype.interfaces
{
    internal interface IAccountPrototype : ICloneable
    {
        public IAccountPrototype clone();
    }
}
