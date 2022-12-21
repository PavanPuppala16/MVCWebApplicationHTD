using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Throw
    {
        static void Div(int i1,int i2)
        {
            int result;
            if(i1==0)
            {
                throw new DivideByZeroException(" the value cant be divode by zero");


            }
            if(i1>100)
            {
                throw new OverflowException("number should be lessthan 100");
            }
            else
            {
                result=i1 / i2;
                Console.WriteLine(result);
                
            }
        }
        class Program
        {
            public static void Test()
            {
                try
                {
                    Throw.Div(2, 38);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
