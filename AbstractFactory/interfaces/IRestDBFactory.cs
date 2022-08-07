using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.AbstractFactory.interfaces
{
    internal interface IRestDBFactory : IRestFactory, IDbFactory
    {
    }
}
