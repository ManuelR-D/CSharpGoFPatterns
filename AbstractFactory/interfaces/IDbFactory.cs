using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.AbstractFactory.interfaces
{
    internal interface IDbFactory
    {
        IConnectionDB getDB(motorDb? engine);
    }
	public enum motorDb
	{
		MYSQL,
		ORACLE,
		POSTGRE,
		SQL
	}
}
