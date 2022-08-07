using CSharpGoFPatterns.Proxy.implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Proxy
{
    internal class ReadConnectionAcessProxy : interfaces.IUserReader
    {
        private implementations.ReadConnection _readConnection;

        ReadConnectionAcessProxy(ReadConnection readConnection)
        {
            _readConnection = readConnection;
        }

        public void readUser(int userId)
        {
            if (checkAccess(userId))
                this._readConnection.readUser(userId);
        }

        private bool checkAccess(int userId)
        {
            //Implement logic to determine wether or not _readConnection has access to read the user with userId
            return true;
        }
    }
}
