using System;

namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a starting number: ");
            int.TryParse(Console.ReadLine(), out var minNum);
            Console.WriteLine("Enter the ending number: ");
            int.TryParse(Console.ReadLine(), out var maxNum);

            for (var i = 0; i <= maxNum - minNum; i++)
            {
                for (var j = minNum; j <= maxNum; j++)
                {
                    var output = j + i;
                    if (output > maxNum)
                    {
                        output -= maxNum;
                    }

                    Console.Write(output);
                }

                Console.WriteLine();
            }
        }
    }
}