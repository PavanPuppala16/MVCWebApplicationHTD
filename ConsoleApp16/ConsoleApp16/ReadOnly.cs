using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class ReadOnly
    {
        /*readonly indicates that assignment to the field can only occur as part of 
         * the declaration or in a constructor in the same class. */

        readonly int x;
        const int x1 = 2;
        public ReadOnly()
        {
            x = 10;
            Console.WriteLine(x);
        }

    }
}

    

