using EmployeeCRUDApp.Models;
using EmployeeCRUDApp.Services;
using EmployeeCRUDApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EmployeeCRUDApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService ;
        public EmployeeController()
        {
           // _employeeService = EmployeeInMemoryService.GetInstance();
           _employeeService = new EmployeeDbService();
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

        [Authorize]
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
        [Authorize]
        public ActionResult Edit(int? id)
        {
            
            EmployeeEditVM vm = new EmployeeEditVM();
            vm.Title = "Edit Employee Details";
            if(id != null)
            {
                var emp = _employeeService.GetById((int)id);
                vm.EmployeeName = emp.Name;
                vm.EmployeeSalary = emp.Salary;
                vm.EmployeeId = emp.Id;
            }

            return View(vm);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeEditVM vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }
            _employeeService.Update(vm.EmployeeId, new Employee { 
                Id = vm.EmployeeId, 
                Name = vm.EmployeeName, 
                Salary = vm.EmployeeSalary
            });
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Delete(int? id)
        {
            
            if (id != null)
            {
                _employeeService.Remove((int)id);
            }
            return RedirectToAction("Index");   
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Index");
        }
    }
}