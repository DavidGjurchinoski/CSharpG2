using Enteties.Exeption;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enteties
{
    public class Movie
    {
        public Movie(string title, Genre genre, int rating, int ticketPrice)
        {
            if(rating > 5 || rating < 1)
            {
                throw new InvalidRatingExeption($"The Rating is {rating} for movie {Title} should not be more then 5 or less then 1!");
            }

            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = ticketPrice;
        }

        public string Title { get; set; }

        public Genre Genre { get; set; }

        public int Rating { get; set; }

        public int TicketPrice { get; set; }


    }
}
