using System;
using static System.Int32;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            TryParse(Console.ReadLine(), out var num);

            String CheckOddEven()
            {
                return num % 2 == 0 ? "Even" : "Odd";
            }

            Console.WriteLine(CheckOddEven());
        }
    }
}
