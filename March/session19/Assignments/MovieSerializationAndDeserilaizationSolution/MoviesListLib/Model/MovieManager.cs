using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesListLib.Model
{
    [Serializable]
    public class MovieManager
    {
        private string _name;
        private int _year;

        public MovieManager(string name, int year)
        {
            _name = name;
            _year = year;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public static void AddMovie(List<MovieManager> movies, string name, int year)
        {
            MovieManager movie = new MovieManager(name, year);
            movies.Add(movie);
        }
    }
}
