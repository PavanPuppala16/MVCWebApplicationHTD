using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class MyEx1
    {

      
             public static void Test()
            {
                double Average;
                Console.WriteLine("enter a number");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter a number");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter a number");
                int n3 = Convert.ToInt32(Console.ReadLine());

                Average = (n1 + n2 + n3) / 3;
                Console.WriteLine("Average:"+Average);
            }
        }
    }

