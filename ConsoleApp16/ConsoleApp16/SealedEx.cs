using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16   // sealed class cant be inhereted
{
    sealed class SealedEx  //sealedex
    {
        public static void Test()
        {
           
                int x = 10, y = 30;
                int z = x + y;
                Console.WriteLine("z is:" + z);
            
        }

    }
}
