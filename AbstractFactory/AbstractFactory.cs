using CSharpGoFPatterns.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.AbstractFactory
{
    internal class AbstractFactory : interfaces.IRestDBFactory
    {
        public IConnectionDB getDB(motorDb? engine)
        {
            return new ConnectionDBFactory().getDB(engine);
        }

        public IConnectionREST getREST(RESTDomain? area)
        {
            return new ConnectionRESTFactory().getREST(area);
        }
    }
}
