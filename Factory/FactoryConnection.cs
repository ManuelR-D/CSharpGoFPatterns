using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpGoFPatterns.Factory.implementations;

namespace CSharpGoFPatterns.Factory
{
    internal class FactoryConnection
    {
		public interfaces.IConnection getConection(motorDb? motor)
		{
			if (motor == null)
			{
				return new ConnectionEmpty();
			}
			if (motor == motorDb.MYSQL)
			{
				return new ConnectionMySQL();
			}
			else if (motor == motorDb.ORACLE)
			{
				return new ConnectionOracle();
			}
			else if (motor == motorDb.POSTGRE)
			{
				return new ConnectionPostgreSQL();
			}
			else if (motor == motorDb.SQL)
			{
				return new ConnectionSQLServer();
			}

			return new ConnectionEmpty();
		}
	}
	public enum motorDb
    {
		MYSQL,
		ORACLE,
		POSTGRE,
		SQL
    }
}
