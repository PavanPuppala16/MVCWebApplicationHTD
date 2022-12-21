using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Fibonacci
    {
        public static void Test()
        {
            int n1 = 0, n2 = 1, n, i, n3;
            Console.WriteLine("enter a numner:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (i=2;i<n;++i)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
;         
        }


    }
}
