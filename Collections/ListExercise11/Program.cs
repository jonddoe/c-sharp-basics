using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var colorList = new List<string>();
            var baseList = new List<string>()
                {"Red", "Black", "Yellow", "Blue", "White", "Orange", "Purple", "Green", "Pink", "Cyan"};

            colorList.AddRange(baseList);

            colorList.RemoveAt(4);
            colorList.Insert(4, "Brown");

            colorList.RemoveAt(colorList.Count - 1);
            colorList.Insert(colorList.Count, "Gray");

            colorList.Sort();

            Console.WriteLine(colorList.Contains("Foobar") ? "Contains" : "Doesn't Contain");

            foreach (var c in colorList)
            {
                Console.WriteLine(c);
            }

            Console.Read();
        }
    }
}