using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Factory.interfaces
{
    internal interface IConnection
    {
        void connect();
        void disconnect();
    }
}
