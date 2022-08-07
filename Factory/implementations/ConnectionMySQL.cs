using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Factory.implementations
{
    internal class ConnectionMySQL : interfaces.IConnection
    {
        public void connect()
        {
            throw new NotImplementedException();
        }

        public void disconnect()
        {
            throw new NotImplementedException();
        }
    }
}
