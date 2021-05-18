using System;

namespace ArraysExercise6
{
    public class RandomNumArrayGenerator
    {
        public static string GenerateRandomArray()
        {
            var random = new Random();
            var randomValueArray = new int[10];
            var copyOfRandomValueArray = new int[10];
            for (var i = 0; i < randomValueArray.Length; i++)
            {
                var randomNumber = random.Next(100);
                randomValueArray[i] = randomNumber;
            }

            for (var i = 0; i < randomValueArray.Length; i++)
            {
                copyOfRandomValueArray[i] = randomValueArray[i];
            }

            randomValueArray[randomValueArray.Length] = -7;
            return
            $"Array 1: {string.Join(" ", randomValueArray)}\nArray 2: {string.Join(" ", copyOfRandomValueArray)}";
           
        }
    }
}