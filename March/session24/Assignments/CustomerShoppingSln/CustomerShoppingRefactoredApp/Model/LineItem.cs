using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingRefactoredApp.Model
{
    internal class LineItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal CalculateItemCost()
        {
            return Product.PriceAfterDiscount() * Quantity;
        }
    }
}
