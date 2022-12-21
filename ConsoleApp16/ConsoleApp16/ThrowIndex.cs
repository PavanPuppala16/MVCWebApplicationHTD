using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class ThrowIndex
    {
         public static int GetValueFromArray(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (IndexOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException(
                    "Parameter index is out of range.", e);
            }
        }
    }
}
