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

            while(guess != secretWord)
            {
                Console.WriteLine("Enter a guess: ");
                guess = Console.ReadLine();
            }
            return guess;
        }
    }
}
