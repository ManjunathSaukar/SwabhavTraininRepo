using MovieListLib.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieListConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore store = new MovieStore();
            store.AddMovie("RRR", 2022);
            store.AddMovie("Laal Singh Chaddha", 2022);

            CaseStudy1Serialization(store.GetMovies());
            CaseStudy2Deserialization();
        }
        static void CaseStudy1Serialization(List<Movie> movies)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream fs = new FileStream("movies1.dump", FileMode.Create, FileAccess.Write);
            formatter.Serialize(fs, movies);
            fs.Close();
            Console.WriteLine("Serialization Successful");
        }
        static void CaseStudy2Deserialization()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream fs = new FileStream("movies1.dump", FileMode.Open, FileAccess.Read);
            List<Movie> movies = (List<Movie>)formatter.Deserialize(fs);

            Console.WriteLine("Deserialization Successful");
            Console.WriteLine("\nMovies:");

            foreach (var movie in movies)
            {
                Console.WriteLine($"Name: {movie.Name} | Year: {movie.Year}");
            }
            fs.Close();
        }
    }
}