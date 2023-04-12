using SimpleFactoryWithSingletonApp.Factory;
using System.Linq.Expressions;

namespace SimpleFactoryWithSingletonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory1 = AutoMobileFactory.Instance;
            var auto = factory1.Make(AutoOptions.AUDI);
            auto.Start();
            auto.Stop();
            auto = factory1.Make(AutoOptions.BMW);
            auto.Start();   
            auto.Stop();

            var factory2 = AutoMobileFactory.Instance;
            var auto2 = factory2.Make(AutoOptions.TESLA);
            auto2.Start();
            auto2.Stop();
            Console.WriteLine(factory1 == factory2);
        }
    }
}