using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.AbstractFactory.implementations
{
    internal class ConnectionPostgreSQL : interfaces.IConnectionDB
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
