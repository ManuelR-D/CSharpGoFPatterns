using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Memento
{
    internal class GameCaretaker
    {
        private List<GameMemento> mementos = new List<GameMemento>();

        public void addMemento(GameMemento gm)
        {
            this.mementos.Add(gm);
        }

        public GameMemento getMemento(int index)
        {
            return this.mementos[index];
        }
    }
}
