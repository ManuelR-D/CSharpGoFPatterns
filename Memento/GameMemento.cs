using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Memento
{
    internal class GameMemento : interfaces.IGameMemento
    {
        private Game state;
        public GameMemento(Game state)
        {
            this.state = state;
        }
        public Game getState()
        {
            return this.state;
        }
    }
}
