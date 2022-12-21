using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16  // example on interface
{
    interface MyInterface   //interface is also override .but defacultly is public and static ,
    {                        // in interface we cant use class keyword also
        void add();


    } 
        class childinterface : MyAbstarct
        {
            public override void add()
            {
            int x = 10, y = 30;
            int z = x + y;
            Console.WriteLine("z is:" + z);

            }





    }
}



