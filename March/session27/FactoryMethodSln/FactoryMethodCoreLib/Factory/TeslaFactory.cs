using FactoryMethodCoreLib.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public class TeslaFactory : IAutoMobileFactory
    {
        private static TeslaFactory instance;
        private TeslaFactory() { }
        public IAutoMobile Make()
        {
            return new Tesla();
        }
        public static TeslaFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TeslaFactory();
                    return instance;
                }
                else return instance;
            }
        }
    }
}
