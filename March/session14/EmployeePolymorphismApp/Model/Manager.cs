using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
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
        public double HouseRentalAllowance { get { return houseRentalAllowance; } }
        public double DearnessAllowaance { get { return dearnessAllowance; } }
        public double TravelAllowance { get { return travelAllowance; } }
        public override double CostToCompany { get { return (houseRentalAllowance + dearnessAllowance + travelAllowance + BasicSalary) * 12; } }
        public override string Role { get { return "Manager"; } }
        public override string SalaryBreakUp
        {
            get
            {
                string formattedSalaryBreakUp = "";
                formattedSalaryBreakUp += "House Rental Allowance : " + houseRentalAllowance;
                formattedSalaryBreakUp += ", Dearness Allowance : " + dearnessAllowance;
                return formattedSalaryBreakUp;
            }
        }

        //public override double CalculateAnnualSalary()
        //{
        //    return (houseRentalAllowance + dearnessAllowance + travelAllowance + BasicSalary) * 12;
        //}

    }
}
