using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public  class MyOverLoading
    {

            public virtual void Add()
        {
            int x = 10, y = 50;
            int z = x + y;
            Console.WriteLine("z is:" + z);

        }
        public  void Add(int x, int y)
        {

            int z = x + y;
            Console.WriteLine("z is:" + z);


        }
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
    
    }
    
}
