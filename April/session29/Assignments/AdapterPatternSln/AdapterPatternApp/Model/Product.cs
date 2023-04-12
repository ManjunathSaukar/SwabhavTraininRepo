using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Model
{
    internal class Product : Item
    {
        private string name;
        private double price;
        private string type;
        public Product(string name, double price, string type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }

        public string ItemName()
        {
            return name;
        }

        public double ItemPrice()
        {
            return price;
        }
    }
}
