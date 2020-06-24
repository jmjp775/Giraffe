using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public class GuessingGame
    {
        public string GetSecretWord(string secretWord)
        {
            string guess;

            Console.WriteLine("Enter a guess: ");
            guess = Console.ReadLine();

            while (!guess.Equals(secretWord, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"Your secret word {guess} is incorrect. Take another guess: ");
                guess = Console.ReadLine();
            }
            return guess;
        }
    }
}
