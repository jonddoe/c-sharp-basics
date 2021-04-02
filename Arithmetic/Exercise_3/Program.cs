using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumAverageRunningInt());
        }

        private static string SumAverageRunningInt()
        {
            Console.Write("Enter a number: ");
            Int32.TryParse(Console.ReadLine(), out var num);
            Console.Write("Enter another number: ");
            Int32.TryParse(Console.ReadLine(), out var num2);

            double sum = 0;
            var count = 0;


            for (var number = num; number <= num2; ++number)
            {
                sum += number;
                count++;
            }

            var average = Math.Round(sum / count, 2);

            return $"The sum of {num} to {num2} is {sum} \n The average is {average}";
        }
    }
}
