using System;
using System.Runtime.InteropServices;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();

            static void Game()
            {
                var words = new[] {"Pirmais", "VARDS", "Otrais", "garakaisvards"};
                var random = new Random();
                var word = words[random.Next(0, words.Length - 1)];
                var limit = 0;
                var missed = string.Empty;
                var masked = new string('-', word.Length);
                var wordArr = word.ToLower().ToCharArray();
                var maskArr = masked.ToCharArray();
                while (limit <= 5)
                {
                    if (limit == 5)
                    {
                        Console.WriteLine("You lose!\nWant to play again? y/n?");
                        if (Console.ReadLine() == "y")
                        {
                            Game();
                        }
                        else
                            System.Environment.Exit(1);
                    }

                    Console.Clear();
                    Console.WriteLine($"Word: {masked}");
                    Console.WriteLine($"Misses:{missed} \n{5 - limit} guesses left.");
                    Console.Write("Guess:");

                    var guessKey = Console.ReadKey();
                    Console.WriteLine();
                    var index = word.ToLower().IndexOf(guessKey.KeyChar);

                    if (index > -1)
                    {
                        for (var i = index; i < wordArr.Length; i++)
                        {
                            if (wordArr[i] != guessKey.KeyChar) continue;
                            maskArr[i] = word[i];
                            masked = new string(maskArr);
                        }
                    }
                    else
                    {
                        missed += guessKey.KeyChar.ToString();
                        limit++;
                    }

                    if (masked.Contains("-")) continue;
                    Console.WriteLine($"\nYou won!\nword was: {word}");
                    Console.WriteLine("\nWant to play again? y/n?");


                    if (Console.ReadLine() == "y")
                    {
                        Game();
                    }
                    else
                        System.Environment.Exit(1);

                    break;
                }


                Console.ReadKey();
            }
        }
    }
}