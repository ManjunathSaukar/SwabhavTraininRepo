// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter an integer:");
string input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    var myClass = new MyLibrary.MyCustomClass();
    myClass.PrintMulTable(number);
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}