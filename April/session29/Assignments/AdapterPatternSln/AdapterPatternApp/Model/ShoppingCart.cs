using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Model
{
    internal class ShoppingCart
    {
        public List<Item> Items { get; set; }
        public ShoppingCart()
        {
            Items = new List<Item>();
        }
        public void Add(Item item)
        {
            Items.Add(item);
        }
        public void Remove(Item item)
        {
            Items.Remove(item);
        }
        public double TotalPrice()
        {
            double totalPrice = 0;

            foreach (Item item in Items)
            {
                totalPrice += item.ItemPrice();
            }

            return totalPrice;
        }
    }
}
