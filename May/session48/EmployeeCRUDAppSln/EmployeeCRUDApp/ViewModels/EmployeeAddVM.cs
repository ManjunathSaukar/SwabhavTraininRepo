using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeCRUDApp.ViewModels
{
    public class EmployeeAddVM
    {
        public string Title { get; set; }
        public string ErrorMessage { get; set; }

        [Required]
        public int EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public double EmployeeSalary { get; set; }
    }
}