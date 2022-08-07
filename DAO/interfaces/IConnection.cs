using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.DAO.interfaces
{
    internal interface IConnection
    {
        void connect();
        void disconnect();
    }
}
