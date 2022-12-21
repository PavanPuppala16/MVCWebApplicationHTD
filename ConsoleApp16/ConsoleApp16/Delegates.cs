using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void CallingAdd();
public delegate int Callingsub(int x, int y);

namespace ConsoleApp16
{
    /*A delegate is a type that represents references to methods with a particular parameter list and return type. */

    class DelegateDemo
        {
            public void Add()
            {
                Console.WriteLine("add");
            }
            public static int sub(int x, int y)
            {
                Console.WriteLine(x - y);
                return 1;
            }
            public static string Name()
            {
                Console.WriteLine("name is xyz");
                return "";
            }
        }
        internal class Delegates
        {
            public static void Test()
            {
            DelegateDemo d1 = new DelegateDemo();

            CallingAdd obj = new CallingAdd(d1.Add);
            obj();
            Callingsub obj1 = new Callingsub(DelegateDemo.sub);
            obj1(78, 12);
            }
        }
    }





