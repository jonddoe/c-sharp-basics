using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            Console.WriteLine(string.Join(",", colors));

            colors.RemoveAt(0);
            colors.Insert(0, "Grey");
            colors.RemoveAt(2);
            colors.Insert(2, "Blue");

            Console.WriteLine(string.Join(",", colors));
            Console.Read();
        }
    }
}