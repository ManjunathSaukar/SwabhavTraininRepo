using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingRefactoredApp.Model
{
    internal class Order
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Count { get { return LineItems.Count; } }
        public DateTime CreatedDate { get; set; }
        public List<LineItem> LineItems { get; set; }

        public Order()
        {
            LineItems = new List<LineItem>();
        }

        public void Add(LineItem lineItem)
        {
            bool existingProduct = false;
            for (int i = 0; i < LineItems.Count; i++)
            {
                if (LineItems[i].Product.Id == lineItem.Product.Id)
                {
                    LineItems[i].Quantity += lineItem.Quantity;
                    existingProduct = true;
                    return;
                }
            }

            if (!existingProduct)
            {
                LineItems.Add(lineItem);
            }
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
