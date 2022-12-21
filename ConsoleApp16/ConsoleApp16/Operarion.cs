using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Operarion
    {
        public void Add()
        {
            Console.WriteLine("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emter y:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z;
            z = x + y;
            Console.WriteLine("Add is:" + z);
        }

    }
}

    

