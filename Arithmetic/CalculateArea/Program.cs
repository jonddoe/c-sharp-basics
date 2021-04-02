using System;


namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = GetMenu();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You chose 1");
                        CalculateCircleArea();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("You chose 2");
                        CalculateRectangleArea();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("You chose 3");
                        CalculateTriangleArea();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Thanks for calculating!");
                        Console.ReadKey();
                        break;
                }
            } while (choice != 4);
        }

        public static int GetMenu()
        {
            Console.Clear();
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            int.TryParse(keyboard.KeyChar.ToString(), out var userChoice);
            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                userChoice = keyboard.KeyChar;
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.Clear();
            Console.WriteLine("What is the circle's radius? ");
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out var radius);

            Console.WriteLine("The circle's area is "
                              + Math.Round(Geometry.areaOfCircle(radius), 2));
        }

        public static void CalculateRectangleArea()
        {
            Console.Clear();
            Console.WriteLine("Enter length? ");
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out var length);

            Console.WriteLine("Enter width? ");
            keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out var width);

            Console.WriteLine("The rectangle's area is "
                              + Math.Round(Geometry.areaOfRectangle(length, width)), 2);
        }

        public static void CalculateTriangleArea()
        {
            Console.Clear();
            Console.WriteLine("Enter length of the triangle's base? ");
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out var ground);

            Console.WriteLine("Enter triangle's height? ");
            keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out var height);

            Console.WriteLine("The triangle's area is "
                              + Math.Round(Geometry.areaOfTriangle(ground, height)), 2);
        }
    }
}