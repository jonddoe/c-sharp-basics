using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> MovieList = new List<Video>();

        public void AddVideo(string title)
        {
            MovieList.Add(new Video(title));
            foreach (var c in MovieList.Where(c => c.MovieName == title))
            {
                c.IsAvailable = true;
            }
        }

        public void Checkout(string title)
        {
            foreach (var c in MovieList.Where(c => c.MovieName == title))
            {
                c.BeingCheckedOut();
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var c in MovieList.Where(c => c.MovieName == title))

            {
                c.BeingReturned();
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var c in MovieList)
            {
                if (c.MovieName == title)
                {
                    c.ReceivingRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            List<Video> movies = MovieList;
            movies = MovieList.OrderBy(x => x.MovieName).ToList();
            Console.WriteLine("\nAvailable movies:");
            foreach (var c in movies.Where(c => c.IsAvailable == true))
            {
                Console.WriteLine($"{c.MovieName}  Average user rating {c.AverageRating()}");
            }

            Console.WriteLine("\nNot available movies:");
            foreach (var c in movies.Where(c => c.IsAvailable == false))
            {
                Console.WriteLine($"{c.MovieName} Average user rating {c.AverageRating()}");
            }

            Console.WriteLine();
        }
    }
}