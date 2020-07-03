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
            int guessCount = 1;
            int guessLimit = 3;
            bool outOfGuesses = false;

            Console.WriteLine("Enter a guess: ");
            guess = Console.ReadLine();

            while (!guess.Equals(secretWord, StringComparison.InvariantCultureIgnoreCase) && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.WriteLine($"Your secret word {guess} is incorrect. Take another guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    //boolean flag
                    outOfGuesses = true;
                }
            }
            if(outOfGuesses)
            {
                Console.WriteLine("Nice try but no cigar! Thanks for playing :)");
            }
            else
            {
                Console.WriteLine("Good guess! You got the correct answer :)");
            }
            return guess;
        }
    }
}
