using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16   // static example program
{
    static class StaticEx
    {
        public static void add()                           //static method
        {
            int x = 10, y = 20, z;
            z = x + y;
            Console.WriteLine("z is :" + z);
        }
        public static int sub(int x, int y)                  //static method
        {
            int z = x - y;
            Console.WriteLine(z);
            return 0;

        }
        public static int div(int x, int y)                   // static method
        {
            int z = x / y;
            Console.WriteLine(z);
            return 0;
        }
        static   StaticEx()                                 //defacult constructor
        {
            Console.WriteLine("defacult constructor");
        }
        public static int Mul(int x, int y, int a)                  //static method with methodoverloading
        {
            int z = x * y * a;
            Console.WriteLine(z);
            return 0;
        }

    }
}
