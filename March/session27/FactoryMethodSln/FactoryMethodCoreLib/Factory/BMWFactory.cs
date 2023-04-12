using FactoryMethodCoreLib.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public class BMWFactory : IAutoMobileFactory
    {
        private static BMWFactory instance;
        private BMWFactory() { }
        public IAutoMobile Make()
        {
            return new BMW();
        }
        public static BMWFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BMWFactory();
                    return instance;
                }
                return instance;
            }
        }
    }
}
