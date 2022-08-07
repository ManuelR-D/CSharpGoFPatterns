using CSharpGoFPatterns.DAO.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.DAO.implementations
{
    internal class PersonDAOMySQL : interfaces.ICrudDao<interfaces.IPersonDTO>, interfaces.IConnection
    {
        public void connect()
        {
            //logic to connect to the db
            throw new NotImplementedException();
        }

        public void disconnect()
        {
            //logic to disconnect from the db
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
