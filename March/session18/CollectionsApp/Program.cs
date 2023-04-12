using CollectionsApp.Model;
using System.Collections;

namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList dmartCart = new ArrayList();
            dmartCart.Add(new LineItem(1, "Milk Bikies", 50, 2));
            dmartCart.Add(new LineItem(2, "Dairy Mily", 100, 1));
            dmartCart.Add(new LineItem(3, "Drawing Book", 100, 3));
            //dmartCart.Add("Manjunath");

            double totalBill = 0;

            foreach (object item in dmartCart)
            {
                LineItem lineItem = (LineItem)item;
                Console.WriteLine($"Id of the item : {lineItem.Id}");
                Console.WriteLine($"Name of the item : {lineItem.Name}");
                Console.WriteLine($"Unit price of the item : {lineItem.UnitPrice}");
                Console.WriteLine($"Quantity of the item : {lineItem.Quantity}");
                Console.WriteLine($"Cost price of the item : {lineItem.CostPrice}");
                Console.WriteLine();
                totalBill += lineItem.CostPrice;
            }
            Console.WriteLine($"Total bill of the items: {totalBill}");
        }
    }
}