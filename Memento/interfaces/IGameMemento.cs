using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Memento.interfaces
{
    internal interface IGameMemento
    {
        public Game getState();
    }
}
