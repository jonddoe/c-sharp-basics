using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            static void PrintDayInWord()
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out var inputIntCheck))
                {
                    Console.WriteLine("Not a valid day");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                    

                switch (inputIntCheck)
                {
                    case 1:
                    {
                        Console.WriteLine("Monday");
                        Console.ReadLine();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Tuesday");
                        Console.ReadLine();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Wednesday");
                        Console.ReadLine();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Thursday");
                        Console.ReadLine();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Friday");
                        Console.ReadLine();
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("Saturday");
                        Console.ReadLine();
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine("Sunday");
                        Console.ReadLine();
                        break;
                    }
                    default:
                        Console.WriteLine("Not a valid day");
                        Console.ReadLine();
                        break;
                }
            }

            PrintDayInWord();
        }
    }
}