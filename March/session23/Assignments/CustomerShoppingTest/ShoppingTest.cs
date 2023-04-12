using CustomerShoppingTest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingTest
{
    [TestClass]
    public class ShoppingTest
    {
        [TestMethod]
        public void CustomerAddOrder_Test()
        {
            var customer = new Customer { Id = 1, Name = "Manjunath" };
            var order = new Order { Id = 1, CreatedDate = DateTime.Today };
            customer.AddOrder(order);

            Assert.AreEqual(1, customer.Orders.Count);
            Assert.AreEqual(order, customer.Orders[0]);
        }

        [TestMethod]
        public void ProductPriceAfterDiscount_Test()
        {
            var product = new Product { Id = 1, Name = "Classmate Note Book", Price = 100, DiscountPercentage = 10 };
            var priceAfterDiscount = product.PriceAfterDiscount();
            Assert.AreEqual(90, priceAfterDiscount);
        }

        [TestMethod]
        public void LineItemCalculateItemCost_Test()
        {
            var product = new Product { Id = 1, Name = "Amul Dark Chocolate", Price = 100, DiscountPercentage = 10 };
            var lineItem = new LineItem { Id = 1, Product = product, Quantity = 2 };
            var itemCost = lineItem.CalculateItemCost();
            Assert.AreEqual(180, itemCost);
        }

        [TestMethod]
        public void OrderCheckOutPrice_Test()
        {
            var order = new Order { Id = 1, CreatedDate = DateTime.Today };
            order.Add(new LineItem { Id = 1, Product = new Product { Id = 1, Name = "Natraj Pencil", Price = 10, DiscountPercentage = 5 }, Quantity = 5 });
            order.Add(new LineItem { Id = 2, Product = new Product { Id = 2, Name = "5 Star Chocolate", Price = 20, DiscountPercentage = 10 }, Quantity = 5 });

            // expected checkout price: 5 * (10 * 0.95) + 5 * (20 * 0.9) = 47.5 + 90 = 137.5
            Assert.AreEqual(137.50M, order.CheckOutPrice());
        }

        [TestMethod]
        public void OrderCheckOutPriceWithNoLineItems_Test()
        {
            var order = new Order { Id = 1, CreatedDate = DateTime.Today };

            Assert.AreEqual(0M, order.CheckOutPrice());
        }

    }
}
