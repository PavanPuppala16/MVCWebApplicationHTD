using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class MyAsyncAwait
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i < 2)
                    {
                        Console.WriteLine(" Method 1");
                    }
                    else
                    {
                        Console.WriteLine("happy");
                    }
                                      
                    Task.Delay(1000).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(" Method 2");
                }
                else
                {
                    Console.WriteLine("happy");
                }

                
                Task.Delay(1000).Wait();
            }
        }
    }
}
        
    

