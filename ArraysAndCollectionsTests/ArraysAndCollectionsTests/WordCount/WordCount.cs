using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        public static string LineWordCharCount()
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

            return $"Lines = {lineArray.Length}\nWords = {wordArray.Length}\nChars = {charArray.Length}";
        }
    }
}