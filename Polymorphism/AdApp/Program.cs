using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200, false));
            c.AddAdvert(new NewspaperAd(0, 30, 20));
            c.AddAdvert(new TvAd(50000, 1000, 30, false));
            c.AddAdvert(new Poster(100, "A4", 1000, 2));
            Console.WriteLine(c);
        }
    }
}