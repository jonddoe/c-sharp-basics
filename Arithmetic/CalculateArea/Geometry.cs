using System;


namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(decimal radius)
        {
            return Math.PI * Math.Pow((double) radius, 2.0);
        }

        public static double areaOfRectangle(decimal length, decimal width)
        {
            return (double) (length * width);
        }

        public static double areaOfTriangle(decimal ground, decimal h)
        {
            return (double) ((ground * h) / 2);
        }
    }
}
