using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class FixityDe
    {
        public static void Test1()
        {
            
                SortedSet<int> obj5 = new SortedSet<int> { 1, 2, 3, 4, 5, 6,7,8,9,10 };
                SortedSet<string> obj6 = new SortedSet<string> { "ramu", "ashok" ,"ramu","ramesh","happy","smily","never","rmesh","rajesh","naven"};
                SortedSet<string> obj7 = new SortedSet<string> { "ramu1@gmail.com", "ashok@gmail.com", "ramu@gmail.com", "ramesh@gmail.com", "happy@gmail.com", "smily@gmail.com", "never2gmail.com", "rmes@gmail.comh", "rajesh@g,mail.com", "naven@gmail.com" };
            foreach (var l in obj5)
                {
                    Console.WriteLine(l);
                }
 
            foreach(var m in obj6)
                {
                    Console.WriteLine(m);
                
                }


            foreach (var o in obj7)
            {
                Console.WriteLine(o);

            }

        }
    }
    
}
