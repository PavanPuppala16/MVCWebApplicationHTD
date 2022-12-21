using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Exception1
    {
        /*A C# exception is a response to an exceptional circumstance that arises while a program is running,
         * such as an attempt to divide by zero*/
     public static void Div()
        {
        TryAgain:
            try
            {
                Console.WriteLine("Enter x Val:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y Val:");
                int y = Convert.ToInt32(Console.ReadLine());
                string str = "test";
                Console.WriteLine("lenth is:" + str.Length);
                int z = x / y;
                Console.WriteLine("Div is:" + z);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Cant find the Lenth od Null Values-->" + ex.Message);
                goto TryAgain;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("U cant Divide anything by Zero-->" + ex.Message);
                goto TryAgain;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("plz Enter Only Int Values-->" + ex.Message);
                goto TryAgain;
            }

        }


    }
}
