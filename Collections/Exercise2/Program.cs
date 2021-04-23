using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();

            mySet.Add("Red");
            mySet.Add("Black");
            mySet.Add("Yellow");
            mySet.Add("Blue");
            mySet.Add("White");

            Console.WriteLine("Should have 5 elements: ");
            Console.WriteLine(string.Join(",", mySet));

            mySet.Clear();

            Console.WriteLine("Is mySet empty: ");
            Console.WriteLine(mySet.Count == 0);

            foreach (var c in mySet)
            {
                Console.WriteLine(c);
            }

            mySet.Add("Green");
            mySet.Add("Orange");
            mySet.Add("Green");
            mySet.Add("Purple");

            Console.WriteLine(string.Join(",", mySet));
            Console.Read();
        }
    }
}