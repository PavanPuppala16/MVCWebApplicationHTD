using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public delegate void CallPmMethod(int x, int y);
    public delegate void CallZeroPmMethod();
    
        class DelDemo2
        {
            public static void add(int x, int y)
            {
                int z = x + y;
                Console.WriteLine("Add is :" + z);
            }
            public static void Sub(int x, int y)
            {
                int z = x - y;
                Console.WriteLine("sub is :" + z);
            }
            public static void mul()
            {
                int x = 78, y = 45;
                int z = x * y;
                Console.WriteLine("Mul is:" + z);
            }
            public static void div()
            {
                int x = 12, y = 2;
                int z = x / y;
                Console.WriteLine("Div is:" + z);
            }
            public static void Fact()
            {
                int x = 12, y = 2;
                int z = x + y;
                Console.WriteLine("Fact is:" + z);
            }
        }

        internal class Multicasting
        {
            public static void Test()
            {
                //single cast delegate
                CallZeroPmMethod obj = new CallZeroPmMethod(DelDemo2.mul);
                obj();
                CallZeroPmMethod obj1 = new CallZeroPmMethod(DelDemo2.div);
                obj1();
                //MulticastDelegate
                CallZeroPmMethod obj2 = new CallZeroPmMethod(DelDemo2.mul);
                obj2 += new CallZeroPmMethod(DelDemo2.div);
                obj2 += new CallZeroPmMethod(DelDemo2.Fact);
                obj2();
                //Multicast delegate Pblms
                CallPmMethod obj3 = new CallPmMethod(DelDemo2.add);
                obj3 += new CallPmMethod(DelDemo2.Sub);
                obj3(12, 5);
            }
        }
    }



