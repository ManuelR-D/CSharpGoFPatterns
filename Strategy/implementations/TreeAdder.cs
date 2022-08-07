using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Strategy.implementations
{
    //Strategy of an action to apply to a tree
    internal class TreeAdder : interfaces.ITreeAction
    {
        private int amount;
        public TreeAdder(int amount)
        {
            this.amount = amount;
        }
        public void execute(BinaryTree tree)
        {
            tree.Value += this.amount;
        }
    }
}
