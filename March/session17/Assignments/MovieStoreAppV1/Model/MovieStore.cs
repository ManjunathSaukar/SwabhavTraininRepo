using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAppV1.Model
{
    internal class MovieStore
    {
        private int numMovies;
        private Movie[] movies;

        public MovieStore()
        {
            numMovies = 0;
            movies = new Movie[10];
        }

        public void AddMovie()
        {
            Console.Write("Enter movie name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter movie year: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("Invalid year. Please enter a valid year: ");
            }

            if (numMovies == movies.Length)
            {
                Array.Resize(ref movies, movies.Length * 2);
            }

            movies[numMovies++] = new Movie { Name = name, Year = year };
        }

        public void DisplayMovies()
        {
            if (numMovies == 0)
            {
                Console.WriteLine("No movies available.");
            }
            else
            {
                Console.WriteLine($"Available movies are: {GetNumMovies()}");
                for (int i = 0; i < numMovies; i++)
                {
                    Console.WriteLine($"Name of the movie: {movies[i].Name}");
                    Console.WriteLine($"Year: {movies[i].Year}\n");
                }
            }
        }
        public int GetNumMovies()
        {
            return numMovies;
        }

    }
}
