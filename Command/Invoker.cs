using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Command
{
    // Composite of operations
    internal class Invoker
    {
        private List<interfaces.IOperation> operations = new List<interfaces.IOperation>();

        public void addOperation(interfaces.IOperation op)
        {
            this.operations.Add(op);
        }

        public void executeOperations()
        {
            foreach(interfaces.IOperation op in operations)
            {
                op.execute();
            }
        }
    }
}
