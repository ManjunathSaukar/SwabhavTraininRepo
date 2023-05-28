using EmployeeCRUDApp.Models;
using EmployeeCRUDApp.Services;
using EmployeeCRUDApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeCRUDApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeService _employeeService ;
        public EmployeeController()
        {
            _employeeService = EmployeeService.GetInstance();
        }
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeIndexVM vm = new EmployeeIndexVM();
            vm.Title = "Employee Home Page";
            vm.Employees = _employeeService.Get();
            vm.Count = _employeeService.HeadCount();
            return View(vm);
        }

        [HttpGet]
        public ActionResult Add()
        {
            EmployeeAddVM vm = new EmployeeAddVM();
            vm.Title = "Add Employee Form";
            return View(vm);
        }
        [HttpPost]
        public ActionResult Add(EmployeeAddVM vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }
             _employeeService.Add(new Employee
            {
                Id = vm.EmployeeID,
                Name = vm.EmployeeName,
                Salary = vm.EmployeeSalary
            }) ;
            return RedirectToAction("Index");
        }
    }
}