using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public class SayHiMethod
    {
        public static void GetUserGreeting(string name)
        {
            string GreetingPhrase = "Hello " + name;
            Console.WriteLine(GreetingPhrase);

        }
    }
}
