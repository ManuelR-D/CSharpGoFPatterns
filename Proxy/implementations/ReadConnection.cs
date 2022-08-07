using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Proxy.implementations
{
    internal class ReadConnection : interfaces.IUserReader
    {
        public void readUser(int userId)
        {
            //Get the user data and do something with it
            throw new NotImplementedException();
        }
    }
}
