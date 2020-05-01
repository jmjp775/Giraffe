using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public static class ArrayExtension
    {
        /// <summary>
        /// simple method that uses Array.IndexOf() to find the element 
        /// and index# in an array.
        /// got an example from here: https://www.techiedelight.com/find-index-of-element-array-csharp/
        /// </summary>
        /// <returns>element</returns>
        /// <returns>index</returns>
        public static int GetIndexOfArray<T>(this T[] array, T item)
        {
            //return the index of the element I want to display
            return Array.IndexOf(array, item);
        }

    }
}
