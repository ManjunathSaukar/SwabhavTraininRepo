using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyItemsCoreLib.Model
{
    public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        private const double _GST = 0.08;

        public Hat(string shortName, string longName, double basePrice)
        {
            _shortName = shortName;
            _longName = longName;
            _basePrice = basePrice;
        }
        public string ShortName
        {
            get { return _shortName; }
        }
        public string LongName
        {
            get { return _longName; }
        }
        public double BasePrice
        {
            get { return _basePrice; }
        }
        public double GetPrice()
        {
            return _basePrice+_basePrice*_GST;
        }
    }
}
