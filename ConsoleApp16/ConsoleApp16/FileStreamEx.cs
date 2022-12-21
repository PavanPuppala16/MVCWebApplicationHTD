using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp16
{
    internal class FileStreamEx
    {
        public static void Test()
        {
            FileStream fs = new FileStream("C:\\Users\\pavan\\visuval programs.txt", FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine("i am pavan");
            }
        }
    }
}
