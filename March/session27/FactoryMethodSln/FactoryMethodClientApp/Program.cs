using FactoryMethodCoreLib.Factory;
using FactoryMethodCoreLib.Factory.Product;

namespace FactoryMethodClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAutoMobileFactory factory1 = TeslaFactory.Instance;
            IAutoMobile auto = factory1.Make();
            auto.start();
            auto.stop();
        }
    }
}