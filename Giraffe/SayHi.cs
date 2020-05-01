using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public static class SayHi
    {
        //
        /// <summary>
        /// Create a method to say Hi to user 
        /// </summary>
        /// <param name="name"></param>
        public SayHi(string name)
        {
            Console.WriteLine("Hello " + name);

            string DisplayGreeting = "Hello " + name;
            var result = Console.WriteLine("Hello " + name);
            return result;
            
        }
    }
}
