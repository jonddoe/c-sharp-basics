using System;
using static System.Int32;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            TryParse(Console.ReadLine(), out var num);
            Console.Write("Enter another number: ");
            TryParse(Console.ReadLine(), out var num2);

            Boolean IsFifteen()
            {
                return num == 15 || num2 == 15 || num + num2 == 15 || num - num2 == 15 || num2 - num == 15;
            }

            Console.WriteLine(IsFifteen());
        }
    }
}
