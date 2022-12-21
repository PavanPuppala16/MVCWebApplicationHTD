using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    
        class Animal
        {
            public virtual void Food()
            {
                Console.WriteLine("This method describes the food for animal");
            }
        }
        class Dog : Animal
        {
            public override void Food()
            {
                Console.WriteLine("The food for dog is meat");
            }
        }

        internal class VirtuvalMethod
        {
            public static void Test1()
            {
                Dog ob = new Dog();
                Animal ob2 = new Animal();
                ob.Food();
                ob2.Food();

            }
        }
    }


