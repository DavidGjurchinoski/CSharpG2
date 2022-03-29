using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Song
    {
        public Song(string title, int lenght, Genre genre)
        {
            Title = title;
            Lenght = lenght;
            Genre = genre;
        }

        public string Title { get; set; }
        public int Lenght { get; set; }
        public Genre Genre { get; set; }

    }
}
