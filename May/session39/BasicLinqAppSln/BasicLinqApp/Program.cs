using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace BasicLinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = args;
            var query1 = names.Where(n => n.ToLower().Contains("a"));
            var query2 = query1.Take(3)
                                .OrderByDescending(n => n);
            query1.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();
            query2.ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}