using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static string AreaOfCircle(decimal radius)
        {
            return $"{(Math.PI * Math.Pow((double)radius, 2.0)):0.00}";
        }

        public static string AreaOfRectangle(decimal length, decimal width)
        {
            return $"{(double)(length * width):0.00}";
        }

        public static string AreaOfTriangle(decimal ground, decimal height)
        {
            return $"{(double)((ground * height) / 2):0.00}";
        }
    }
}