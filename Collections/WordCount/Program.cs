using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string textRaw;
            using (var sr = new StreamReader("../WordCount/lear.txt"))
            {
                textRaw = sr.ReadToEnd();
            }

            var textSplitWithSpace = Regex.Replace(textRaw, @"(\s)\s+", " ");

            var lineArray = textRaw.Split('\n');
            var wordArray = textSplitWithSpace.Split(' ');
            var charArray = textSplitWithSpace.ToCharArray();

            Console.WriteLine($"Lines = {lineArray.Length}");
            Console.WriteLine($"Words = {wordArray.Length}");
            Console.WriteLine($"Chars = {charArray.Length}");
            Console.Read();
        }
    }
}
