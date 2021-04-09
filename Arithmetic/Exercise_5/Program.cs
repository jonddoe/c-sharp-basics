using System;
using System.Runtime.InteropServices;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var num = rnd.Next(100);
            var guessCount = 2;

            do
            {
                Console.WriteLine($"I'm thinking of a number between 1-100. You have {guessCount} guesses.");
                Int32.TryParse(Console.ReadLine(), out var userGuess);

                if (userGuess == num)
                {
                    Console.WriteLine("You guessed it!  What are the odds?!?");
                    guessCount = 0;
                }
                else if (userGuess < num)
                {
                    Console.WriteLine("Too low!");
                    guessCount--;
                }
                else if (userGuess > num)
                {
                    Console.WriteLine("Too high!");
                    guessCount--;
                }

                if (userGuess != num && guessCount == 0)
                {
                    Console.WriteLine("You lose!");
                }
            } while (guessCount > 0);
        }
    }
}