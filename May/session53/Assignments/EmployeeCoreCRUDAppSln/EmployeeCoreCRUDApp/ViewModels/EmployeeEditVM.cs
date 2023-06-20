using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmployeeCoreCRUDApp.ViewModels
{
    public class EmployeeEditVM
    {
        public string Title { get; set; }

        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Employee Name is required.")]
        public string EmployeeName { get; set; }

        [Display(Name = "Employee Salary")]
        [Required(ErrorMessage = "Employee Salary is required.")]
        public double EmployeeSalary { get; set; }
    }
}
