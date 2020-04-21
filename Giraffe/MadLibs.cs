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

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love  " + celebrity);

            var ReturnMadLibsPhrase = 
            //Console.ReadLine();
        }
       
    }
}
