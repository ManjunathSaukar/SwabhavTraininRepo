using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismUnitTestApp.Model
{
    internal class Manager : Employee
    {
        private double houseRentalAllowance;
        private double dearnessAllowance;
        private double travelAllowance;
        public Manager(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            houseRentalAllowance = 0.6 * basicSalary;
            dearnessAllowance = 0.5 * basicSalary;
            travelAllowance = 0.4 * basicSalary;
        }
        public override double CalculateAnnualSalary()
        {
            return (houseRentalAllowance + dearnessAllowance + travelAllowance + BasicSalary) * 12;
        }
    }
}
