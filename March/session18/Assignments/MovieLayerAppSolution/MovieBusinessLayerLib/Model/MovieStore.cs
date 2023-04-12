using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBusinessLayerLib.Model
{
    public class MovieStore
    {
        private  Movie[] _movies = new Movie[5];
        private int _count = 0;

        public void Add(Movie movie)
        {
            if (_count >= _movies.Length)
            {
                Array.Resize(ref _movies, _movies.Length * 2);
            }

            _movies[_count++] = movie;
        }

        public Movie[] GetMovies()
        {
            Movie[] result = new Movie[_count];
            Array.Copy(_movies, result, _count);
            return result;
        }
    }
}
