using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingTest.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<LineItem> LineItems { get; set; }

        public Order()
        {
            LineItems = new List<LineItem>();
        }

        public void Add(LineItem lineItem)
        {
            LineItems.Add(lineItem);
        }

        public decimal CheckOutPrice()
        {
            decimal total = 0;
            foreach (var item in LineItems)
            {
                total += item.CalculateItemCost();
            }
            return total;
        }

    }
}
