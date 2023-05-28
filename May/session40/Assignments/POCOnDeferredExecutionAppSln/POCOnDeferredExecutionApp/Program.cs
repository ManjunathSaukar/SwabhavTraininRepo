namespace POCOnDeferredExecutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var query = numbers.Where(n => n % 2 == 0); // Deferred execution

            Console.WriteLine("Query created.");

            numbers.Add(12);

            query.ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
