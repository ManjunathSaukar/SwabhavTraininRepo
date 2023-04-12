﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingTest.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercentage { get; set; }

        public decimal PriceAfterDiscount()
        {
            return Price * (1 - (DiscountPercentage / 100));
        }
    }
}
