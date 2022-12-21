using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class MyPractice
    {
        public static void Test()    //formateexception
        {
            TryAgain:
            try
            { // user input as test
                Console.WriteLine("enter your name");
                string name = Console.ReadLine();
                Console.WriteLine(name);
                Console.WriteLine("enter your name");
                string name2 = Console.ReadLine();
                Console.WriteLine(name2);
                //userinput as a integer
                Console.WriteLine("enter your lucky number:");
                int num = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException ex)
            {
                Console.WriteLine(""+ex.Message);
                goto TryAgain;
            }
        }
    
        public static void String()   //operations on string
        {
        TryAgain:
            try
            {
                Console.WriteLine("enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine(name);
                Console.WriteLine(name.Length);
                Console.WriteLine(name.ToUpper());
                Console.WriteLine(name.ToLower());
                Console.WriteLine(name[3]);
            }
            catch(Exception ex)
            {
                Console.WriteLine("its wrong:" + ex.Message);
                goto TryAgain;
            }
        }
   
        public static void method()    //method example
        {
            Console.WriteLine("method exam ");

        }
        public static void method1(string name)   // method with parameters
        {
            
            Console.WriteLine(name + "kumar");
        }
    
    }

}
