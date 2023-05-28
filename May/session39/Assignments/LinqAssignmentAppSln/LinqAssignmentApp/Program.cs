namespace LinqAssignmentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = args;
            CaseStudy1(names);
            Console.WriteLine();

            string[] stringNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            CaseStudy2(stringNumbers);
        }

        private static void CaseStudy2(string[] stringNumbers)
        {
            // Use LINQ to map each string number to its integer equivalent
            var numbers = stringNumbers.Select(s => int.Parse(s));
            Console.WriteLine("Mapped numbers: " + string.Join(", ", numbers));

            // Use LINQ to reduce the numbers to their sum
            var sum = numbers.Aggregate((x, y) => x + y);
            Console.WriteLine("Sum: " + sum);

            // Use LINQ to filter out the odd numbers and reduce the remaining even numbers to their sum
            var evenSum = numbers.Where(n => n % 2 == 0).Aggregate((x, y) => x + y);
            Console.WriteLine("Sum of even numbers: " + evenSum);

            // Use LINQ to filter out the even numbers and reduce the remaining even numbers to their sum
            var oddSum = numbers.Where(n => n % 2 != 0).Aggregate((x, y) => x + y);
            Console.WriteLine("Sum of odd numbers: " + oddSum);
        }

        private static void CaseStudy1(string[] names)
        {
            // Display all the names in ascending order
            Console.WriteLine("All names in ascending order:");
            var sortedNames = names.OrderBy(n => n, StringComparer.OrdinalIgnoreCase);
            foreach (string name in sortedNames)
            {
                Console.WriteLine(name);
            }

            // Display all the names in descending order based on the size of their name
            Console.WriteLine("\nAll names in descending order based on the size of their name:");
            var sortedNamesByLength = names.OrderByDescending(n => n.Length);
            foreach (string name in sortedNamesByLength)
            {
                Console.WriteLine(name);
            }

            // Display all the names which contains "s"
            Console.WriteLine("\nAll names which contains 's':");
            var namesContainingS = names.Where(n => n.Contains("s", StringComparison.OrdinalIgnoreCase));
            foreach (string name in namesContainingS)
            {
                Console.WriteLine(name);
            }

            // Display all the names that doesn't contain "a"
            Console.WriteLine("\nAll names that doesn't contain 'a':");
            var namesNotContainingA = names.Where(n => !n.Contains("a", StringComparison.OrdinalIgnoreCase));
            foreach (string name in namesNotContainingA)
            {
                Console.WriteLine(name);
            }
        }
    }
}