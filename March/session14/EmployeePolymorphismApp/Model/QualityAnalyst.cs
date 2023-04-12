using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public double Perks { get { return perks; }  }
        public override double CostToCompany { get { return (perks + BasicSalary) * 12; } }
        public override string Role { get { return "Quality Analyst"; } }
        public override string SalaryBreakUp
        {
            get
            {
                return "Perks : " + Perks;
            }
        }
        //public override double CalculateAnnualSalary()
        //{
        //    return (perks + BasicSalary) * 12;
        //}
    }
}
