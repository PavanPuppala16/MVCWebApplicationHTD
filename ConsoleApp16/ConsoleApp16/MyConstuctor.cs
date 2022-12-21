using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class MyConstuctor
    {

        public MyConstuctor()
        {
            int x = 10, y = 60;
            int z = x + y;
            Console.WriteLine(z);
        }
        public MyConstuctor(int x,int y)
        {
           
            int z = x - y;
            Console.WriteLine(z);
        }
        public void mul()
        {
            int x = 10, y = 60;
            int z = x * y;
            Console.WriteLine(z);
        }
       
    }
}
