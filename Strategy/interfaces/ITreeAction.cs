using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Strategy.interfaces
{
    internal interface ITreeAction
    {
        void execute(BinaryTree tree);
    }
}
