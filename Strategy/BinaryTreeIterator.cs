using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Strategy
{
    //Iterator of a binary tree, where you can specify a traverse strategy for the iteration and an action to execute.
    internal class BinaryTreeIterator
    {
        private interfaces.ITreeTraversal traverseStrategy;
        private interfaces.ITreeAction actionStrategy;

        public void setActionStrategy(interfaces.ITreeAction action)
        {
            this.actionStrategy = action;
        }
        public void setTraverseStrategy(interfaces.ITreeTraversal traverse)
        {
            this.traverseStrategy = traverse;
        }

        public void traverse()
        {
            this.traverseStrategy.traverse();
        }

    }
}
