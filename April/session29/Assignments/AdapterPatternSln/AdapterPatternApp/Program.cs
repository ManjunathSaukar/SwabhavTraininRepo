using AdapterPatternApp.Model;
using FancyItemsCoreLib.Model;

namespace AdapterPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new ShoppingCart();
            c.Add(new Product("Harry Potter", 80,"Book"));
            c.Add(new Product("Cello Ballpoint Pen", 10,"Pen"));
            c.Add(new HatAdapter(new Hat("Golden","Golden Premium",999)));
            PrintDetails(c);
        }
        static void PrintDetails(ShoppingCart cart)
        {
            Console.WriteLine("Items in cart:");

            foreach (Item item in cart.Items)
            {
                Console.WriteLine($"Name : {item.ItemName()}");
                Console.WriteLine($"Type : {item.GetType().Name}");
                Console.WriteLine($"Price : {item.ItemPrice()}");
                Console.WriteLine();
            }

            Console.WriteLine($"Total Price: {cart.TotalPrice()}");
            Console.WriteLine();
        }
    }
}