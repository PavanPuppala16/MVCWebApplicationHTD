using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    partial class MyPartialEx
    {
        public static void Test()
        {

            int x = 10, y = 30;
            int z = x + y;
            Console.WriteLine("z is:" + z);

        }
        public static void Test1()
        {

            int x = 10, y = 30;
            int z = x + y;
            Console.WriteLine("z is:" + z);

        }

        public static void Test3(int x, int y)
        {
            int z = x * y;
            Console.WriteLine("z is :" + z);

        }


    }
    partial class MyPartialEx
    {
        public static void Test4()
        {

            int x = 60, y = 30;
            int z = x / y;
            Console.WriteLine("z is:" + z);

        }
        public static void Test5(int x, int y)
        {
            int z = x % y;
            Console.WriteLine("z is :" + z);

        }


    }
}
