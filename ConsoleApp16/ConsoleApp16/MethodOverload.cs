using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class MethodOverload
    {
        public void M1()
        {
            Console.WriteLine("task1");
        }
        public void M1(int x)
        {
            Console.WriteLine("task2 with parameter");
        }
        public void M1(string str)
        {
            Console.WriteLine("task3 with string");
        }
        public void M1(int x, int y)
        {
           Console.WriteLine("task4 with two parameters");
        }
    }
}