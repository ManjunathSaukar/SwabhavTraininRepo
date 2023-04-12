using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPVoilationApp.Model
{
    internal class Invoice
    {
        private readonly int _id;
        private readonly string _description;
        private readonly double _cost;
        private readonly double _discountPercent;
        private const double _tax = 0.10;

        public Invoice(int id, string description, double cost, double discount)
        {
            _id = id;
            _description = description;
            _cost = cost;
            _discountPercent = discount;
        }

        public double CalculateTax()
        {
            return _tax*_cost;
        }

        public double CalculateDiscount()
        {
            return _discountPercent*_cost;
        }

        public double FinalCost()
        {
            return _cost + CalculateTax() - CalculateDiscount();
        }

        public void PrintInvoice()
        {
            string template = $"Id : {_id}\n" +
                $", Description : {_description}\n" +
                $"Cost : {_cost}\n" +
                $"Tax amnount is : ${CalculateTax()}\n" +
                $"Discount Amount is : {CalculateDiscount()}\n" +
                $"Final Cost : {FinalCost()}\n";
            Console.WriteLine(template);
        }
    }
}
