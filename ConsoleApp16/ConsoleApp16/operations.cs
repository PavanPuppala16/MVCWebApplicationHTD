using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class operations
    {/*addition subtraction mul operation that are passing with parametres,without parameters,with static*/
        public  void addtion()
        {
            int x = 10, y = 60, z;
            z = x + y;
            Console.WriteLine("addition:" + z);
        }
        public void subtraction(int x,int y)
        {
            int z = x - y;
            Console.WriteLine("subtraction:" + z);
        }
        public static void mul()
        {
            int x=8, y=3;
            int z = x * y;
            Console.WriteLine("mul:" + z);
        }    
    }
}
