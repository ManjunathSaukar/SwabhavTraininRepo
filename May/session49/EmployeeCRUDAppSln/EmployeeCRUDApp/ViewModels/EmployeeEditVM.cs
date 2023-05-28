using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeCRUDApp.ViewModels
{
    public class EmployeeEditVM
    {
        public string Title { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public double EmployeeSalary { get; set; }
        public string ErrorMessage { get; set; }
    }
}