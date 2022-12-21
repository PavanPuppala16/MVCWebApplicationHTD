using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ConsoleApp16
{
    internal class Timeout
    {

        public static void main()
        {
            string input;
            try
            {
                
                SerialPort sp = new SerialPort("COM1", 4800, Parity.Odd, 8, StopBits.One);

                sp.ReadTimeout = 2000;
                sp.Open();

                
                input = sp.ReadLine();

                sp.Close();


                Console.WriteLine(input);
            }

            catch (TimeoutException e)
            {
                Console.WriteLine(e);
            }
        }


    }
}