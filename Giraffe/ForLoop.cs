using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public static class ForLoop
    {
        /// <summary>
        /// try this example: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/passing-arrays-as-arguments
        /// use this section: ChangeArray(weekDays);
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static void GetLengthOfArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
