using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    internal class QualityAnalyst : Employee
    {
        private double perks;
        public QualityAnalyst(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            perks = 0.4* basicSalary;
        }
        public override double CalculateAnnualSalary()
        {
            return (perks + BasicSalary) * 12;
        }
    }
}
