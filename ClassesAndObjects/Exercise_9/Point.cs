namespace Exercise_9
{
    class Point
    {
        public int X { set; get; }
        public int Y { set; get; }

        public static void SwapPoints(Point x, Point y)
        {
            var tempXx = x.X;
            var tempXy = x.Y;
            x.X = y.X;
            x.Y = y.Y;
            y.X = tempXx;
            y.Y = tempXy;
        }
    }
}
