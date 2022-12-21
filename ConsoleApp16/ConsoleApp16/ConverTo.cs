using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class ConverTo
    {
        public static void Test()
        {
            int res;
            string name = null;
            res = Convert.ToInt32(name);
            Console.WriteLine(res);
        }
        public static void Test1()
        {
            int res;
            string name = "5000";
            res = int.Parse(name);
            Console.WriteLine(res);
        }
    }
}
