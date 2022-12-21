using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Formate
    {
        public static void Test()
        {
            
                TryAgain:
                try
                {
                Console.WriteLine("Enter x Val:");
                int x = Convert.ToInt32(Console.ReadLine());
            }
                catch (FormatException ex)
                {
                    Console.WriteLine("plz Enter Only str Values-->" + ex.Message);
                    goto TryAgain;
                }
            
            
        }
    }
}
