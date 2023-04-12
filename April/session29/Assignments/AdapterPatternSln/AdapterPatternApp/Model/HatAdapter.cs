using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemsCoreLib.Model;

namespace AdapterPatternApp.Model
{
    internal class HatAdapter : Item
    {
        private Hat _hat;

        public HatAdapter(Hat hat)
        {
            _hat = hat;
        }

        public string ItemName()
        {
            return _hat.ShortName;
        }

        public double ItemPrice()
        {
            return _hat.GetPrice();
        }

    }
}
