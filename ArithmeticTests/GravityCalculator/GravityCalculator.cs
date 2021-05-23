using System;

namespace GravityCalculator
{
    public class GravityCalculator
    {
        public static string CalculateFallingObject(int fallingTime)
        {
            const double gravity = -9.81;
            const double initialVelocity = 0.0;
            const double initialPosition = 0.0;
            var finalPosition = (gravity * (Math.Pow(fallingTime, 2) / 2) + (initialVelocity * fallingTime) +
                                 initialPosition);

            return "The object's position after " + fallingTime + " seconds is " + finalPosition + " m.";
        }
    }
}