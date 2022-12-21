using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    partial class PartialEx
    {       /* a single class into multiple files and all these files are combined into a single class file */
        public void Test()
        {
            Console.WriteLine("normal method");

        }
    }
    partial class PartialEx
    {
        public static void Test1()
        {
            Console.WriteLine("static method");
        }
    }
    partial class PartialEx
    {
        public PartialEx()
        {
            Console.WriteLine("Constructor");
        }
    }  
}
