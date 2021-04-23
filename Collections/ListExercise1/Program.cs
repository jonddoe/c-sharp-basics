using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Black");
            colors.Add("White");
            colors.Add("Blue");
            colors.Add("Orange");

            foreach (var c in colors)
            {
                Console.WriteLine(c);
            }

            Console.Read();
        }
    }
}