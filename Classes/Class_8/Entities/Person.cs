using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Person
    {
        public Person(int id, string firstName, string lastName, int age, Genre favoriteMusicType, List<Song> favoriteSongs)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs ?? new List<Song>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public void GetFavoriteSongs()
        {
            if (FavoriteSongs.Count > 0)
            {
                //foreach (Song song in FavoriteSongs)
                //{
                //    Console.WriteLine(song.Title);
                //}

                FavoriteSongs
                 .Where(song => song.Genre == Genre.Rock)
                 .ToList()
                 .ForEach(song => Console.WriteLine(song.Title));

                FavoriteSongs
                 .Select(song => song.Genre)
                 .ToList()
                 .ForEach(genre => Console.WriteLine(genre));
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} hates music!");
            }

        }
    }
}
