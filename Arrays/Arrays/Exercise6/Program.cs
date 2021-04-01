using System;


namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var randomValueArray1 = new int[10];
            var copyOfRandomValueArray = new int[10];
            for (var i = 0; i < randomValueArray1.Length; i++)
            {
                var randomNumber = random.Next(100);
                randomValueArray1[i] = randomNumber;
            }

            for (var i = 0; i < randomValueArray1.Length; i++)
            {
                for (var j = 0; j < 1; j++)
                {
                    copyOfRandomValueArray[i] = randomValueArray1[i];
                }
            }


            for (var i = randomValueArray1.Length; i == randomValueArray1.Length; i++)
            {
                randomValueArray1[^1] = -7;
            }

            Console.WriteLine($"Array 1: {string.Join(" ", randomValueArray1)}");
            Console.WriteLine($"Array 2: {string.Join(" ", copyOfRandomValueArray)}");
            Console.ReadLine();
        }
    }
}