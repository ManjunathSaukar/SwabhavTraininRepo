using MovieBusinessLayerLib.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieStoreAppV3
{
    internal class Program
    {
        private static readonly string dataFile = "moviestore.dump";
        private static MovieStore? store;
        static void Main(string[] args)
        {
            store = MovieStore.Load(dataFile);

            DisplayMenu();
        }
        private static void DisplayMenu()
        {
            Console.WriteLine("Welcome to Movie store App\n");
            while (true)
            {
                Console.WriteLine("Available Movies : " + store.Count);
                Console.WriteLine("\nChoices : ");
                Console.WriteLine("1. Add a movie");
                Console.WriteLine("2. Display available movies");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddMovie();
                            break;

                        case 2:
                            DisplayMovies();
                            break;

                        case 3:
                            store.Save(dataFile);
                            Console.WriteLine("Thank You for using MovieStore App");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }

        private static void AddMovie()
        {
            Console.Write("\nEnter movie name: ");
            string name = Console.ReadLine()!;

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid movie name. Try again.");
                return;
            }

            Console.Write("Enter movie year: ");

            if (int.TryParse(Console.ReadLine(), out int year))
            {
                store.Add(new Movie(name, year));
                Console.WriteLine("Movie added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid movie year. Try again.");
            }
        }

        private static void DisplayMovies()
        {
            List<Movie> movies = store.GetMovies();

            Console.WriteLine("\nAvailable movies: \n");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"Movie Name: {movies[i].Name} | Movie Year: {movies[i].Year}");
            }
        }
    }
}