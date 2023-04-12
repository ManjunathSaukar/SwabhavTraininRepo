using CustomerShoppingRefactoredApp.Model;

namespace CustomerShoppingRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product book = new Product { Id = 1, Name = "Book", Price = 50, DiscountPercentage = 10 };
            Product pen = new Product { Id = 2, Name = "Pen", Price = 10, DiscountPercentage = 5 };
            Product chocolate = new Product { Id = 3, Name = "Chocolate", Price = 20, DiscountPercentage = 2 };

            LineItem item1 = new LineItem { Id = 101, Quantity = 2, Product = book };
            LineItem item2 = new LineItem { Id = 102, Quantity = 2, Product = pen };
            LineItem item3 = new LineItem { Id = 103, Quantity = 1, Product = chocolate };

            Order order1 = new Order { Id = 1, Name = "Dmart Order", CreatedDate = DateTime.Now };
            order1.Add(item1);
            order1.Add(item2);
            order1.Add(item1);
            order1.Add(item2);
            order1.Add(item3);

            Console.WriteLine("Order ID: {0}", order1.Id);
            Console.WriteLine("Order Name: {0}", order1.Name);
            Console.WriteLine("Order Date: {0}", order1.CreatedDate);

            Console.WriteLine("Items:");
            foreach (LineItem item in order1.LineItems)
            {
                Console.WriteLine("{0} - Quantity: {1}", item.Product.Name, item.Quantity);
            }
        }
    }
}