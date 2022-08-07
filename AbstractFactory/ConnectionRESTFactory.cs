using CSharpGoFPatterns.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpGoFPatterns.AbstractFactory.implementations;
namespace CSharpGoFPatterns.AbstractFactory
{
    internal class ConnectionRESTFactory : interfaces.IRestFactory
    {
        public IConnectionREST getREST(RESTDomain? area)
        {
			if (area == null)
			{
				return new ConnectionRESTEmpty();
			}
			if (area == RESTDomain.BUY)
			{
				return new ConnectionRESTBuy();
			}
			else if (area == RESTDomain.SELL)
			{
				return new ConnectionRESTSell();
			}

			return new ConnectionRESTEmpty();
		}
    }
}
