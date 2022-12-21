using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class MultiLevel
    {
        /*the involvement of at least two or more than two classes.
         * One class inherits the features from a parent class and
         * the newly created sub-class becomes the base class for another new class*/
        public int a, b, c;
        public void Add()
        {
            a = 19; b = 34;
            c = a + b;
            Console.WriteLine("Add is:" + c);
        }
        class FirstClass : MultiLevel
        {
            public void Mul()
            {
                
                a = 23; b = 12;
                c = a * b;
                Console.WriteLine("Mul:" + c);


            }
        }

        class SecondClass : FirstClass
        {
            public void Sub()
            {
                
                a = 19; b = 12;
                c = a - b;
                Console.WriteLine("Sub:" + c);
            }
        

        }

    }
}


