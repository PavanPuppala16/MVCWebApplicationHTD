using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp16
{
    internal class AsyncAwait
    {
        
            public static async void CallMethod()
            {
                string filePath = "C:\\Users\\pavan\\visuval programs.txt";
                Task<int> task = ReadFile(filePath);

                Console.WriteLine(" Other Work 1");
                Console.WriteLine(" Other Work 2");
                Console.WriteLine(" Other Work 3");

                int length = await task;
                Console.WriteLine(" Total length: " + length);

                Console.WriteLine(" After work 1");
                Console.WriteLine(" After work 2");
            }

            public static async Task<int> ReadFile(string file)
            {
                int length = 0;

                Console.WriteLine(" File reading is stating");
                using (StreamReader reader = new StreamReader(file))
                {
                    // Reads all characters from the current position to the end of the stream asynchronously
                    // and returns them as one string.
                    string s = await reader.ReadToEndAsync();

                    length = s.Length;
                    Task.Delay(10000).Wait();
                }
                Console.WriteLine(" File reading is completed");
                return length;

            }
        

    }
}
