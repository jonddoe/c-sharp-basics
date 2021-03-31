using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = int.Parse(Console.ReadLine());


            if (input > 0)
            {
                Console.WriteLine("Number is positive");
                Console.ReadLine();
            }
            else if (input < 0)
            {
                Console.WriteLine("Number is negative");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number is zero");
                Console.ReadLine();
            }
        }
    }
}
