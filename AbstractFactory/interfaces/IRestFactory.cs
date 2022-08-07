using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.AbstractFactory.interfaces
{
    internal interface IRestFactory
    {
        IConnectionREST getREST(RESTDomain? area);
    }
    public enum RESTDomain
    {
        BUY,
        SELL
    }
}
