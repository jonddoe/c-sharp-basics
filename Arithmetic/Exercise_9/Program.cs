using System;
using System.Runtime.Intrinsics.X86;

namespace Exercise_9
{
    class Program
    {
        static void BmiCalculatorPounds()
        {
            Console.WriteLine("Enter your weight in pounds");
            int.TryParse(Console.ReadLine(), out var weight);
            Console.WriteLine("Enter your height in inches");
            int.TryParse(Console.ReadLine(), out var height);
            var bmi = 703 * (weight / Math.Pow(height, 2));

            Console.WriteLine($"Your BMI is: {Math.Round(bmi, 2)}");
            switch (bmi)
            {
                case <= 18.5:
                    Console.WriteLine("You're underweight!");
                    break;
                case > 18.5 and < 24.9:
                    Console.WriteLine("You have normal weight!");
                    break;
                case > 25 and < 29.9:
                    Console.WriteLine("You're overweight!");
                    break;
                case > 30 and < 39.9:
                    Console.WriteLine("You're obese!");
                    break;
                case > 40:
                    Console.WriteLine("You're morbidly obese!");
                    break;
            }
        }

        static void BmiCalculatorKilos()
        {
            Console.WriteLine("Enter your weight in kilograms");
            int.TryParse(Console.ReadLine(), out var weight);
            Console.WriteLine("Enter your height in centimeters");
            int.TryParse(Console.ReadLine(), out var height);
            var bmi = (weight / Math.Pow(height, 2) * 10000);
            Console.WriteLine($"Your BMI is: {Math.Round(bmi, 2)}");
            switch (bmi)
            {
                case < 18.5:
                    Console.WriteLine("You're underweight!");
                    break;
                case > 18.5 and < 24.9:
                    Console.WriteLine("You have normal weight!");
                    break;
                case > 25 and < 29.9:
                    Console.WriteLine("You're overweight!");
                    break;
                case > 30 and < 39.9:
                    Console.WriteLine("You're obese!");
                    break;
                case > 40:
                    Console.WriteLine("You're morbidly obese!");
                    break;
            }
        }

        public static int GetMenu()
        {
            Console.Clear();
            Console.WriteLine("BMI Calculator\n");
            Console.WriteLine("1. Pounds");
            Console.WriteLine("2. Kilograms");
            Console.WriteLine("Enter your choice (1-2) : ");
            var keyboard = Console.ReadKey();
            int.TryParse(keyboard.KeyChar.ToString(), out var userChoice);
            while (userChoice < 1 || userChoice > 2)
            {
                Console.WriteLine("Please enter a valid range: 1, 2");
                keyboard = Console.ReadKey();
                userChoice = keyboard.KeyChar;
            }

            return userChoice;
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                choice = GetMenu();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nYou chose pounds");
                        BmiCalculatorPounds();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\nYou chose kilograms");
                        BmiCalculatorKilos();
                        Console.ReadKey();
                        break;
                }
            } while (choice != 3);
        }
    }
}