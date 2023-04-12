using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryWithSingletonApp.Factory
{
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _instance;
        private AutoMobileFactory()
        {
            
        }
        public static AutoMobileFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AutoMobileFactory();
                }
                return _instance;
            }
        }

        public IAutoMobile Make(AutoOptions autoOptions)
        {
            switch (autoOptions)
            {
                case AutoOptions.BMW:
                    return new BMW();
                case AutoOptions.TESLA:
                    return new Tesla();
                case AutoOptions.AUDI:
                    return new Audi();
                default:
                    throw new ArgumentException($"Invalid auto option: {autoOptions}");
            }
        }
    }
}
