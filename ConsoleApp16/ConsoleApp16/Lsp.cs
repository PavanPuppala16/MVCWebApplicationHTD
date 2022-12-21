using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
  
       public class Pavan
        {
            static void Test()
            {
                Fruit fruit = new Orange();
                Console.WriteLine(fruit.GetColor());
                fruit = new Apple();
                Console.WriteLine(fruit.GetColor());
            }
        }
        public abstract class Fruit
        {
            public abstract string GetColor();
        }
        public class Apple : Fruit
        {
            public override string GetColor()
            {
            Console.WriteLine("red");
            return "Red";
            }
        }
        public class Orange : Fruit
        {
            public override string GetColor()
            {
            Console.WriteLine("orange");
                return "Orange";
            }
        }
    }

