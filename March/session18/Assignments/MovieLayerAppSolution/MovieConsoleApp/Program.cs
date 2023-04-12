using MovieBusinessLayerLib.Model;
namespace MovieConsoleApp
{
    internal class Program
    {
        private static readonly MovieStore store = new MovieStore();
        static void Main(string[] args)
        {
            DisplayMenu();
        }
        private static void DisplayMenu()
        {
            Console.WriteLine("Welcome to Movie store App\n");
            while (true)
            {
                Console.WriteLine("Available Movies : " + store.GetMovies().Length);
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
            Movie[] movies = store.GetMovies();

            Console.WriteLine("\nAvailable movies: \n");
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    Console.WriteLine($"Movie Name: {movies[i].Name} | Movie Year: {movies[i].Year}");
                }
            }
        }
    }
}
