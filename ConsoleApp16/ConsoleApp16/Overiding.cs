using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
	class baseClass

	{
		public void show()
		{
			Console.WriteLine("Base class");
		}
	}


	class derived : baseClass
	{

		// overriding
		new public void show()
		{
			Console.WriteLine("Derived class");
		}
	}
}
	
	