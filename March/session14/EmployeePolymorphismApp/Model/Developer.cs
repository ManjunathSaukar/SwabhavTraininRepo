using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    internal class Developer : Employee
    {
        private double performanceAllownace;
        private double overTimeAllowance;
        public Developer(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            performanceAllownace = 0.5 * basicSalary;
            overTimeAllowance = 0.4 * basicSalary;
        }

        public double PerformanceAllowance { get { return performanceAllownace; } }
        public double OverTimeAllowance { get { return overTimeAllowance; } }

        public override double CostToCompany { get { return (performanceAllownace + overTimeAllowance + BasicSalary) * 12; } }

        public override string SalaryBreakUp
        {
            get
            {
                string formattedSalaryBreakUp = "";
                formattedSalaryBreakUp += "Performance Allowance : " + performanceAllownace;
                formattedSalaryBreakUp += ", Over Time Allownance : " + overTimeAllowance;
                return formattedSalaryBreakUp;
            }
        }

        public override string Role { get { return "Developer"; } }
        //public override double CalculateAnnualSalary()
        //{
        //    return (performanceAllownace + overTimeAllowance + BasicSalary) * 12;
        //}
    }
}
