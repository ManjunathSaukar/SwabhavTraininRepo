using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListLib.Model
{
    public class MovieStore
    {
        private readonly List<Movie> _movies = new();

        public void AddMovie(string name, int year)
        {
            var movie = new Movie(name, year);
            _movies.Add(movie);
        }

        public List<Movie> GetMovies()
        {
            return _movies;
        }
    }
}
