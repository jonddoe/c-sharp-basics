using System;
using System.Collections.Generic;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            var inputNumberList = new List<int>();
            Console.Write("Input the 1st number: ");
            var input1 = Int32.Parse(Console.ReadLine());
            inputNumberList.Add(input1);

            Console.Write("Input the 2nd number: ");
            var input2 = Int32.Parse(Console.ReadLine());
            inputNumberList.Add(input2);

            Console.Write("Input the 3rd number: ");
            var input3 = Int32.Parse(Console.ReadLine());
            inputNumberList.Add(input3);


            var biggestInputNumber = 0;
            foreach (var i in inputNumberList)
            {
                if (i > biggestInputNumber) biggestInputNumber = i;
            }

            Console.WriteLine($"Biggest number of the three is {biggestInputNumber}");
            Console.ReadLine();
        }
    }
}
