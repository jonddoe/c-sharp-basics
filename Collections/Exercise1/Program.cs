using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            string[] origination = { "Germany", "Germany", "Japan", "Germany", "Germany", "USA" };

            var list = new List<string>();
            foreach (var c in array)
            {
                list.Add(c);
            }

            Console.WriteLine(string.Join(",", list));

            var hashset = new HashSet<string>();
            foreach (var c in array)
            {
                hashset.Add(c);
            }

            Console.WriteLine(string.Join(",", hashset));

            var dictionary = new Dictionary<string, string>();
            string[] uniqueCarArray = hashset.ToArray();
            for (int i = 0; i < origination.Length; i++)
            {
                dictionary.Add(uniqueCarArray[i], origination[i]);
            }

            Console.WriteLine(string.Join(",", dictionary));
            Console.Read();
        }
    }
}