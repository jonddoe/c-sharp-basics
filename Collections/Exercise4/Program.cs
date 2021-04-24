using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameList = new HashSet<string>();
            var printNamesEntered = false;
            while (printNamesEntered == false)
            {
                Console.WriteLine("Enter a name:");
                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    printNamesEntered = true;
                }

                nameList.Add(name);
            }

            Console.Write("Unique name list contains: ");
            foreach (var c in nameList)
            {
                Console.Write(c + " ");
            }

            Console.Read();
        }
    }
}