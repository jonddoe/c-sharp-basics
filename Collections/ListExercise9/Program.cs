using System;
using System.Collections.Generic;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };
            Console.WriteLine("First List:");
            Console.WriteLine(string.Join(",", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };
            Console.WriteLine("Second List:");
            Console.WriteLine(string.Join(",", secondList));

            firstList.AddRange(secondList);

            Console.WriteLine("Joined List:");
            Console.WriteLine(string.Join(",", firstList));
            Console.Read();
        }
    }
}