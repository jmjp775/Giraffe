using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public class MadLibs
    {
        public string PlayMadLibs()
        {
            /// <summary>
            /// Create a simple madlib game
            /// </summary>
            /// 

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            String Line1 = "Roses are " + color + ", ";
            string Line2 = pluralNoun + " are blue" + ", ";
            string Line3 = "I love " + celebrity + " ";

            var ReturnMadLibsPhrase = string.Concat(Line1, Line2, Line3);
            return ReturnMadLibsPhrase;
            //Console.ReadLine();
        }
       
    }
}
