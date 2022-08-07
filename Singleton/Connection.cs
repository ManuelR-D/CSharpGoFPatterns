using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Singleton
{
    internal class Connection
    {
		private static Connection instance;

		//Prevent use of "new"
		private Connection()
		{

		}

		//Static method to get an instance of this class. Such instance will be stored
		public static Connection getInstance()
		{
			if (instance == null)
			{
				instance = new Connection();
			}
			return instance;
		}

		public void conectar()
		{
			Console.WriteLine("Connected to BDD");
		}

		public void desconectar()
		{
			Console.WriteLine("Disconnected from BDD");
		}
	}
}
