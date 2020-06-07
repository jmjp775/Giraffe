using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public class IncrementWhileLoop
    {
        public int IncrementInt(int initialValue)
        {
            while (initialValue <= 5)
            {
                Console.WriteLine("Value is: {0}", initialValue);
                ++initialValue;
            }
            return initialValue;
        }
    }
}