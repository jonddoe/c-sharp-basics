using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product1ToN());
        }

        private static long Product1ToN()
        {
            Console.Write("Enter a number: ");
            Int32.TryParse(Console.ReadLine(), out var num);
            Console.Write("Enter another number: ");
            Int32.TryParse(Console.ReadLine(), out var num2);
            long numIntervalMultiplied = 1;

            for (var number = num; number <= num2; ++number)
            {
                numIntervalMultiplied *= number;
            }

            return numIntervalMultiplied;
        }
    }
}
