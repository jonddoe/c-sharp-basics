using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out var number);

            for (int i = 1; i <= number; i++)
            {
                var fizz = (i % 3 == 0) && ((i % 5 != 0));
                var buzz = (i % 5 == 0) && (i % 3 != 0);
                var fizzBuzz = (i % 3 == 0) && (i % 5 == 0);
                if (fizz)
                {
                    Console.Write("Fizz ");
                }

                if (buzz)
                {
                    Console.Write("Buzz ");
                }

                if (fizzBuzz)
                {
                    Console.Write("FizzBuzz ");
                }

                if (fizz == false && buzz == false && fizzBuzz == false)
                {
                    Console.Write(i + " ");
                }

                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
