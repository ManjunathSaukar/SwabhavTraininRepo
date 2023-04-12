using BirdLSPRefactoredApp.Model;

namespace BirdLSPRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot parrot1 = new Parrot();
            Pigeon pigeon1 = new Pigeon();
            Ostrich ostrich1 = new Ostrich();

            CaseStudy1(parrot1, pigeon1);
            CaseStudy2(ostrich1);
        }

        private static void CaseStudy2(Ostrich ostrich1)
        {
            Console.WriteLine("Birds That Cannot Fly:");
            ostrich1.CannotFly();
            Console.WriteLine();
        }

        private static void CaseStudy1(Parrot parrot1, Pigeon pigeon1)
        {
            Console.WriteLine("Birds That Can Fly:");
            parrot1.Fly();
            pigeon1.Fly();
            Console.WriteLine();
        }
    }
}