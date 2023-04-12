using MovieStoreAppV1.Model;
using static System.Formats.Asn1.AsnWriter;

namespace MovieStoreAppV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore movieStore = new MovieStore();

            Console.WriteLine("Welcome to Movie Store App");
            Console.WriteLine($"Available Movies : {movieStore.GetNumMovies()}");

            while (true)
            {
                Console.WriteLine("Choices:");
                Console.WriteLine("1. Add a movie");
                Console.WriteLine("2. Display available movies");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        while (true)
                        {
                            movieStore.AddMovie();

                            Console.Write("Do you want to add more movies? (y/n): ");
                            string answer = Console.ReadLine()!;
                            if (answer.ToLower() == "n")
                            {
                                Console.WriteLine($"Available movies afetr adding are : {movieStore.GetNumMovies()}");
                                break;
                            }
                        }

                        break;

                    case "2":
                        movieStore.DisplayMovies();
                        break;

                    case "3":
                        Console.WriteLine("Thank you for visiting Movie Store App.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid choice.");
                        break;
                }
            }

        }
    }
}