using DIPRefactoredWithDelegateApp.HighLevel;
using DIPRefactoredWithDelegateApp.LowLevel;

namespace DIPRefactoredWithDelegateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator((XMLErrorLogger.Log));
            Console.WriteLine(calc.CalculateTax(10, 2));
            Console.WriteLine(calc.CalculateTax(10, 0));
        }
    }
}