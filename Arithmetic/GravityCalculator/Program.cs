using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var gravity = -9.81;
            var initialVelocity = 0.0;
            var fallingTime = 10.0;
            var initialPosition = 0.0;
            var finalPosition = (gravity * (Math.Pow(fallingTime, 2) / 2) + (initialVelocity * fallingTime) +
                                 initialPosition);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}