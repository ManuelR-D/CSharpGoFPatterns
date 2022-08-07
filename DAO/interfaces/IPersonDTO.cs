using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.DAO.interfaces
{
    internal interface IPersonDTO
    {
        public int Id { get; }
        public string Name { get; }
    }
}
