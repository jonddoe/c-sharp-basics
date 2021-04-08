using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowPigletGame();
        }

        static int RollDice()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 7);
            return randomNumber;
        }

        private static void ShowPigletGame()
        {
            Console.Clear();
            var points = 0;
            Console.WriteLine("Welcome to Piglet!\nEnter y to roll the dice!");
            var answer = Console.ReadLine();
            var isGameOn = true;
            while (isGameOn)
            {
                if (answer == "y")
                {
                    var rolledValue = RollDice();
                    if (rolledValue != 1)
                    {
                        Console.WriteLine($"You rolled a {rolledValue}!\nRoll again? y/n");
                        answer = Console.ReadLine();
                        points += rolledValue;
                    }

                    if (rolledValue == 1)
                    {
                        points = 0;
                        Console.WriteLine($"You rolled a {rolledValue}!\nYou got {points} points. \nPlay again? y/n");
                        answer = Console.ReadLine();
                        isGameOn = false;
                        if (answer == "y")
                        {
                            ShowPigletGame();
                        }
                    }
                }

                if (answer != "n") continue;
                Console.WriteLine($"You got {points} points. \nPlay again? y/n");
                answer = Console.ReadLine();
                isGameOn = false;
                if (answer == "y")
                {
                    ShowPigletGame();
                }
            }
        }
    }
}