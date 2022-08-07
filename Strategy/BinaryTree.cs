using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Strategy
{
    internal class BinaryTree
    {
        public BinaryTree? LeftTree { get; set; }
        public BinaryTree? RightTree { get; set; }
        public int Value { get; set; }

        public BinaryTree(int value)
        {
            this.Value = value;
        }

    }
}
