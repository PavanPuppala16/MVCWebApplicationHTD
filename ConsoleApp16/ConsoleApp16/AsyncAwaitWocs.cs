using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp16
{
    internal class AsyncAwaitWocs
    {

            public static void CallMethod()
            {
                string filePath = "C:\\Users\\pavan\\visuval programs.txt";
                int length = ReadFile(filePath);  // 10000ms

                Console.WriteLine(" Other Work 1");
                Console.WriteLine(" Other Work 2");
                Console.WriteLine(" Other Work 3");

                Console.WriteLine(" Total length: " + length);

                Console.WriteLine(" After work 1");
                Console.WriteLine(" After work 2");
            }

            static int ReadFile(string file)
            {
                int length = 0;

                Console.WriteLine(" File reading is stating");
                using (StreamReader reader = new StreamReader(file))
                {
                    // Reads all characters from the current position to the end of the stream asynchronously
                    // and returns them as one string.
                    string s = reader.ReadToEnd();

                    length = s.Length;
                    Task.Delay(10000).Wait();
                }
                Console.WriteLine(" File reading is completed");
                return length;
            }
     }
}
