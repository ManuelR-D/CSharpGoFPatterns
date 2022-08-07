using CSharpGoFPatterns.Strategy.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Strategy.implementations
{
    //Tree traversal strategy that traverse the tree and applies an action as strategy to each value
    internal class PostOrderTraversal : interfaces.ITreeTraversal
    {
        private BinaryTree tree;
        private interfaces.ITreeAction action;
        public PostOrderTraversal(BinaryTree tree)
        {
            this.tree = tree;
        }

        public void setAction(ITreeAction action)
        {
            this.action = action;
        }

        public void traverse()
        {
            if(tree.LeftTree != null)
                new PostOrderTraversal(tree.LeftTree).traverse();
            if (tree.RightTree != null)
                new PostOrderTraversal(tree.RightTree).traverse();
            action.execute(tree);
        }
    }
}
