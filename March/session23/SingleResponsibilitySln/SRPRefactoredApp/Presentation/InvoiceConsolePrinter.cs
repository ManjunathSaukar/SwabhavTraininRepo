using SRPRefactoredApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactoredApp.Presentation
{
    internal class InvoiceConsolePrinter
    {
        public void PrintToConsole(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string template = $"Id : {invoice.Id}\n" +
                $", Description : {invoice.Description}\n" +
                $"Cost : {invoice.Cost}\n" +
                $"Tax amnount is : ${invoice.CalculateTax()}\n" +
                $"Discount Amount is : {invoice.CalculateDiscount()}\n" +
                $"Final Cost : {invoice.FinalCost()}\n";
            Console.WriteLine(template);
        }
    }
}
