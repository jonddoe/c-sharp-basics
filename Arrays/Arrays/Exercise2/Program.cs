using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        
        //TODO: Write a C# program to sum values of an array.
        private static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());
            foreach (var t in myArray)
            {
                sum += t;
            }

            int[] inputGeneratedArray = Enumerable.Range(minNumber, maxNumber).ToArray();
            var inputGeneratedArraySum = 0;
            foreach (var t in inputGeneratedArray)
            {
                inputGeneratedArraySum += t;
            }

            Console.WriteLine("The sum of default array is " + sum);
            Console.WriteLine("The sum of users array is " + inputGeneratedArraySum);
            Console.ReadKey();
        }
    }
}
