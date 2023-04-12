using MoviesListLib.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieListConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MovieManager> movies = new List<MovieManager>();

            MovieManager.AddMovie(movies, "RRR", 2022);
            MovieManager.AddMovie(movies, "Forrest Gump", 1994);

            FileStream fs1 = CaseStyudySerialization(movies);

            CaseStudyDeserialization(movies, fs1);
        }

        private static FileStream CaseStyudySerialization(List<MovieManager> movies)
        {
            BinaryFormatter formatter1 = new BinaryFormatter();

            FileStream fs1 = new FileStream("movies1.dump", FileMode.Create, FileAccess.Write);
            formatter1.Serialize(fs1, movies);
            fs1.Close();
            Console.WriteLine("Serialization Successful");
            return fs1;
        }

        private static void CaseStudyDeserialization(List<MovieManager> movies, FileStream fs1)
        {
            BinaryFormatter formatter2 = new BinaryFormatter();

            FileStream fs2 = new FileStream("movies1.dump", FileMode.Open, FileAccess.Read);
            List<MovieManager> deserializedMovies = (List<MovieManager>)formatter2.Deserialize(fs2);

            Console.WriteLine("Deserialization Successful");
            Console.WriteLine("\nMovies:");

            foreach (var movie in deserializedMovies)
            {
                Console.WriteLine($"Name: {movie.Name} | Year: {movie.Year}");
            }
            fs1.Close();
        }
    }
}