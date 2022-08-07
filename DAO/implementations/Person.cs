using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.DAO.implementations
{
    internal class Person : interfaces.IPersonDTO
    {
        private int id;
        private string name;
        public int Id => this.id;

        public string Name => this.name;
    }
}
