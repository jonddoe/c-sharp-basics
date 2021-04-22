using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        public string MovieName { get; set; }

        public bool IsAvailable { get; set; }

        public List<double> RatingList = new List<double>();

        public Video(string title)
        {
            MovieName = title;
        }

        public void BeingCheckedOut()
        {
            IsAvailable = false;
        }

        public void BeingReturned()
        {
            IsAvailable = true;
        }

        public void ReceivingRating(double rating)
        {
            RatingList.Add(rating);
        }

        public double AverageRating()
        {
            return Math.Round(RatingList.Sum() / RatingList.Count);
        }
        
    }
}