using BirdLSPVoilationApp.Model;

namespace BirdLSPVoilationApp
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
            ostrich1.Fly(); //prints ostriches cannot fly
            Console.WriteLine();
        }

        private static void CaseStudy1(Parrot parrot1, Pigeon pigeon1)
        {
            parrot1.Fly();
            pigeon1.Fly();
            Console.WriteLine();
        }
    }
}