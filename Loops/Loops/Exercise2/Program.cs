using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            Console.WriteLine("Input number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine(Pow(i, n));
            }

            Console.ReadKey();
        }

        static int Pow(int number, int times)
        {
            var a = number;
            for (var i = times; i > 1; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    a = number * number;
                }

                a *= number;
            }

            return a;
        }
    }
}