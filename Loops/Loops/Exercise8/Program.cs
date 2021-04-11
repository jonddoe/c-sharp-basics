using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            Int32.TryParse(Console.ReadLine(), out var num);
            Console.WriteLine(AsciiFigure(num));
        }

        static string AsciiFigure(int num)
        {
            var figure = "";

            for (int i = 0; i < num; i++)
            {
                for (int j = num - 1; j > i; j--)
                {
                    figure += "////";
                }

                for (int j = 1; j <= i * 2; j++)
                {
                    figure += "****";
                }

                for (int j = num - 1; j > i; j--)
                {
                    figure += "\\\\\\\\";
                }

                figure += "\n";
            }

            return figure;
        }
    }
}