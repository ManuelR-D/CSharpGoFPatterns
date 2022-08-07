using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpGoFPatterns.DAO.interfaces;

namespace CSharpGoFPatterns.DAO.implementations
{
    internal class PersonDAORedis : ICrudDao<IPersonDTO>, IConnection
    {
        public void connect()
        {
            //logic to connect to the redis sv
            throw new NotImplementedException();
        }

        public void disconnect()
        {
            //logic to disconnect from the redis sv
            throw new NotImplementedException();
        }

        //CRUD operations over IPersonDTO.
        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public IPersonDTO get(int id)
        {
            throw new NotImplementedException();
        }

        public IPersonDTO save(IPersonDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool update(IPersonDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
