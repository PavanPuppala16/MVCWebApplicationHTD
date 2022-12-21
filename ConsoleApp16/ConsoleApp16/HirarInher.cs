using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class HirarInher
    {
        /* a situation in which a parent class is inherited by multiple subclasses.*/
        public int a;
        public void Test()
        {
            a = 10;
            Console.WriteLine("a:" + a);
        }
        public void Test1()
        {
            a = 12;
            Console.WriteLine("a:" + a);
        }
        class ChildClassA: HirarInher
        {
            public void Test2()
            {
                a = 23;
                Console.WriteLine("a:" + a);
            }
        class ChildClassB : HirarInher
            {
                public void Test3()
                {
                    Test();
                    Test1();
                    int a = 199;
                    Console.WriteLine("a:" + a);
                }
            }
        }
    }
}
