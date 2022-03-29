using Entities;
using System.Collections.Generic;

namespace Exercise_2
{
    class Program
    {
        static List<Song> songsList = new List<Song>()
        {
            { new Song("SongTitle1", 3, Genre.Hip_Hop) },
            { new Song("SongTitle2", 5, Genre.Rock) },
            { new Song("SongTitle3", 6, Genre.Techno) }
        };

        static void Main(string[] args)
        {
            Person user = new Person(1, "User1", "LastUser1", 22, Genre.Hip_Hop, songsList);

            user.GetFavoriteSongs();

            Person user2 = new Person(2, "User2", "LastUser2", 22, Genre.Rock, null);

            user2.GetFavoriteSongs();


        }
    }
}
