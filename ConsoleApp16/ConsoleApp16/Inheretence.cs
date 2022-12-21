using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Inheretence
    {
        /*the reception of genetic qualities by transmission from parent*/
            public int x, y, z;
            public void Add()
            {
                 x = 19; y = 34;
                 z = x + y;
                 Console.WriteLine("Add is:" + z);
            }
            public void Mul()
            {
            x = 23; y = 12;
            z = x * y;
            Console.WriteLine("Mul:" + z);

            
            } 
    }

        class ChildClass:Inheretence
       
        {
            public void Sub()
            {
             x = 19; y = 12;
             z = x - y;
                Console.WriteLine("Sub:" + z);
            }
            public void Div()
            {
            x = 2; y = 4;
            z = x / y;
                Console.WriteLine("Div:" + z);
            }

        }

}
