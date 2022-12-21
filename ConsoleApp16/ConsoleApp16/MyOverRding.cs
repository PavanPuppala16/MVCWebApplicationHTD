using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class MyOverRding
    {
        public virtual void Add()
        {
            int x = 10, y = 30;
            int z = x + y;
            Console.WriteLine("z is:" + z);

        }

        class chilsclass : MyOverRding
        {
            public override void Add()
            {
                Console.WriteLine("Enter x Val:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y Val:");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x + y;
                Console.WriteLine(z);
            }

        }
    }
}
