using System;
using System.Runtime.CompilerServices;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads a positive integer and counts the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();


            if (long.TryParse(input, out var longInput))
            {
               
                if (longInput < 0)
                {
                    longInput *= -1;
                }

                if (longInput >= 10000000000L)
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                    Console.ReadLine();
                }
                else
                {
                    var digits = 1;
                    if (longInput >= 10 && longInput < 100)
                    {
                        digits = 2;
                    }
                    else if (longInput >= 100 && longInput < 1000)
                    {
                        digits = 3;
                    }
                    else if (longInput >= 1000 && longInput < 10000)
                    {
                        digits = 4;
                    }
                    else if (longInput >= 10000 && longInput < 100000)
                    {
                        digits = 5;
                    }
                    else if (longInput >= 100000 && longInput < 1000000)
                    {
                        digits = 6;
                    }
                    else if (longInput >= 1000000 && longInput < 10000000)
                    {
                        digits = 7;
                    }
                    else if (longInput >= 10000000 && longInput < 100000000)
                    {
                        digits = 8;
                    }
                    else if (longInput >= 100000000 && longInput < 1000000000)
                    {
                        digits = 9;
                    }
                    else if (longInput >= 1000000000 && longInput < 10000000000L)
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The number is not a long");
                Console.ReadLine();
            }
        }
    }
}