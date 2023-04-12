using SRPRefactoredApp.Model;
using SRPRefactoredApp.Presentation;

namespace SRPRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Training Invoice", 100, .50);
            InvoiceConsolePrinter printer = new InvoiceConsolePrinter();
            printer.PrintToConsole(invoice);

            InvoiceHTMLPrinter printer2 = new InvoiceHTMLPrinter();
            printer2.PrintToHTML(invoice);
            Console.WriteLine("End");
        }
    }
}