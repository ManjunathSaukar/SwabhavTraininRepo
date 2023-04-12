using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MovieBusinessLayerLib.Model
{
    [Serializable]
    public class MovieStore
    {
        private List<Movie> _movies = new List<Movie>();

        public void Add(Movie movie)
        {
            _movies.Add(movie);
        }

        public List<Movie> GetMovies()
        {
            return _movies;
        }

        public int Count => _movies.Count;
        public void Save(string fileName)
        {
            using Stream stream = File.Open(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
        }

        public static MovieStore Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                using Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                return (MovieStore)formatter.Deserialize(stream);
            }
            else
            {
                return new MovieStore();
            }
        }
    }
}
