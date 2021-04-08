using System;

namespace Exercise4
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            for (var i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i] + " ");
            }

            Console.WriteLine();
            foreach (var t in vowels)
            {
                Console.Write(t + " ");
            }

            Console.ReadLine();
        }
    }
}
