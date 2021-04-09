using System;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            var sum = 0;

            foreach (var i in numbers)
            {
                sum += i;
            }

            var averageValue = sum / numbers.Length;

            Console.WriteLine("Average value of the array elements is : " + averageValue);
            Console.ReadKey();
        }
    }
}
