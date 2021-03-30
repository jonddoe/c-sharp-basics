using System;

namespace SadFor
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test1();
        }

        private static void Test1()
        {
            //fixme so I would compile

            for (double i = 0; i < 10; i++)
            {
                if (Math.Round(Math.Sqrt(i), 2) > 2.5)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();
        }
    }
}