using SRPRefactoredApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactoredApp.Presentation
{
    internal class InvoiceHTMLPrinter
    {
        public void PrintToHTML(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string template = $"Id : {invoice.Id}\n" +
                $", Description : {invoice.Description}\n" +
                $"Cost : {invoice.Cost}\n" +
                $"Tax amnount is : ${invoice.CalculateTax()}\n" +
                $"Discount Amount is : {invoice.CalculateDiscount()}\n" +
                $"Final Cost : {invoice.FinalCost()}\n";

            StreamWriter sw = new StreamWriter(invoice.Id + ".html");
            sw.WriteLine("<html>");
            sw.WriteLine("<body>");
            sw.WriteLine("<body>");
            sw.WriteLine("<h1>");
            sw.WriteLine(template);
            sw.WriteLine("</h1>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();

            //StreamWriter sw = new StreamWriter(invoice.Id + ".html");
            //sw.WriteLine("<html>");
            //sw.WriteLine("<body>");
            //sw.WriteLine("<body>");
            //sw.WriteLine("<h1>Invoice Details </h1>");
            //sw.WriteLine("<ol>");
            //sw.WriteLine($"<h2><li>Id: {invoice.Id}</li></h2>");
            //sw.WriteLine($"<h2><li>Description: {invoice.Description}</li></h2>");
            //sw.WriteLine($"<h2><li>Cost: {invoice.Cost}</li></h2>");
            //sw.WriteLine($"<h2><li>Tax amount: ${invoice.CalculateTax()}</li></h2>");
            //sw.WriteLine($"<h2><li>Discount amount: {invoice.CalculateDiscount()}</li></h2>");
            //sw.WriteLine($"<h2><li>Final cost: {invoice.FinalCost()}</li></h2>");
            //sw.WriteLine("</ol>");
            //sw.WriteLine("</body>");
            //sw.WriteLine("</html>");
            //sw.Close();
        }
    }
}
