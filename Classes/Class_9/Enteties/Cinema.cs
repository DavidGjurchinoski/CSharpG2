using System;
using System.Collections.Generic;
using System.Text;

namespace Enteties
{
    public class Cinema
    {
        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public string Name { get; set; }

        public List<int> Halls { get; set; }

        public List<Movie> Movies { get; set; }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}");
        }
    }
}
