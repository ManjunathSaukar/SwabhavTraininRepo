using GuitarApp.Model;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            Guitar searchGuitar1 = new Guitar("", 0, "Fender", "Stratocastor", "electric", "Alder", "Alder");
            Guitar foundGuitar1 = inventory.Search(searchGuitar1);
            PrintResult(foundGuitar1);
            Guitar searchGuitar2 = new Guitar("", 0, "Gibson", "Les Paul", "electric", "Mahogany", "Maple");
            Guitar foundGuitar2 = inventory.Search(searchGuitar2);
            PrintResult(foundGuitar2);

            static void PrintResult(Guitar foundGuitar)
            {
                if (foundGuitar != null) 
                {
                    Console.WriteLine($"Found the guitar with the following properties:");
                    Console.WriteLine($"Builder: {foundGuitar.Builder}");
                    Console.WriteLine($"Model: {foundGuitar.Model}");
                    Console.WriteLine($"Type: {foundGuitar.Type}");
                    Console.WriteLine($"BackWood: {foundGuitar.BackWood}");
                    Console.WriteLine($"TopWood: {foundGuitar.TopWood}");
                    Console.WriteLine($"Price : {foundGuitar.Price}");
                }
                else
                {
                    Console.WriteLine("Sorry, we have no guitars that match your specifications.");
                }
                Console.WriteLine();
            }
        }
        static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("V95693", 1499.95, "Fender", "Stratocastor", "electric", "Alder", "Alder");
            inventory.AddGuitar("V9512", 1549.95, "Fender", "Stratocastor", "electric", "Alder", "Alder");
        }
    }
}