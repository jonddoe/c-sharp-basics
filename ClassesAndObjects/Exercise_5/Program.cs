using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day: ");
            int.TryParse(Console.ReadLine(), out var d);
            Console.WriteLine("Enter month: ");
            int.TryParse(Console.ReadLine(), out var m);
            Console.WriteLine("Enter year: ");
            int.TryParse(Console.ReadLine(), out var y);

            Date DateTest = new Date();

            DateTest.SetDate(d, m, y);
            Console.WriteLine(DateTest.DisplayDate());
        }
    }
}
