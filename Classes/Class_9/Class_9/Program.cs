using Enteties;
using System;
using System.Collections.Generic;

namespace Class_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cinema> listOfCinemas = new List<Cinema>()
            {
                new Cinema("Cinema1", new List<int> {1, 2, 3, 4, 5}, new List<Movie>
                {
                    new Movie("Movie1", Genre.Action, 5, 100),
                    new Movie("Movie2", Genre.Comedy, 5, 400),
                    new Movie("Movie3", Genre.Action, 4, 100),
                    new Movie("Movie4", Genre.Horror, -5, 100),
                    new Movie("Movie5", Genre.Action, 2, 1600),
                    new Movie("Movie6", Genre.Drama, 5, 100),
                    new Movie("Movie7", Genre.Horror, 11, 100),
                    new Movie("Movie8", Genre.Action, 5, 1080),
                    new Movie("Movie9", Genre.SciFi, 56, 10110),
                    new Movie("Movie10", Genre.SciFi, -5, 10900),
                }),
                new Cinema("Cinema2", new List<int> {6, 7, 3, 4, 5}, new List<Movie>
                {
                    new Movie("Movie1", Genre.Action, 5, 100),
                    new Movie("Movie2", Genre.Comedy, 1, 400),
                    new Movie("Movie3", Genre.Action, 5, 141200),
                    new Movie("Movie4", Genre.Horror, 66, 11100),
                    new Movie("Movie5", Genre.Action, 5, 1642100),
                    new Movie("Movie6", Genre.Drama, 41, 104210),
                    new Movie("Movie7", Genre.Horror, 5, 105210),
                    new Movie("Movie8", Genre.Action, 1, 1080),
                    new Movie("Movie9", Genre.SciFi, 5, 10110),
                    new Movie("Movie10", Genre.SciFi, 4, 10900),
                }),
                new Cinema("Cinema3", new List<int> {12, 2, 3, 4, 5}, new List<Movie>
                {
                    new Movie("Movie1", Genre.Action, 5, 14200),
                    new Movie("Movie2", Genre.Comedy, 5, 400),
                    new Movie("Movie3", Genre.Action, 5, 10110),
                    new Movie("Movie4", Genre.Horror, 5, 10310),
                    new Movie("Movie5", Genre.Action, 5, 1600),
                    new Movie("Movie6", Genre.Drama, 5, 100),
                    new Movie("Movie7", Genre.Horror, 5, 100),
                    new Movie("Movie8", Genre.Action, 5, 1080),
                    new Movie("Movie9", Genre.SciFi, 5, 10110),
                    new Movie("Movie10", Genre.SciFi, 5, 10900),
                }),
            };  

            try
            {
                Console.WriteLine("Rate the movie");

            }
            catch(Exception exeption)
            {
                Console.WriteLine($"An error occured during the runtime! \n {exeption}");
            }
            finally
            {
                Console.WriteLine("The program is finished!");
            }
        }
    }
}
