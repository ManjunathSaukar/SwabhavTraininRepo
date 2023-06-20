using EmployeeCoreCRUDApp.Models;
using EmployeeCoreCRUDApp.Services;
using EmployeeCoreCRUDApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCoreCRUDApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = EmployeeService.GetInstance();
        }

        public IActionResult Index()
        {
            var vm = new EmployeeIndexVM
            {
                Title = "Employee Home Page",
                Employees = _employeeService.Get(),
                Count = _employeeService.HeadCount()
            };
            return View(vm);
        }

        //[Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            var vm = new EmployeeAddVM
            {
                Title = "Add Employee Form"
            };
            return View(vm);
        }

        //[Authorize]
        [HttpPost]
        public IActionResult Add(EmployeeAddVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            _employeeService.Add(new Employee
            {
                Id = vm.EmployeeID,
                Name = vm.EmployeeName,
                Salary = vm.EmployeeSalary
            });

            return RedirectToAction("Index");
        }

        //[Authorize]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var vm = new EmployeeEditVM
            {
                Title = "Edit Employee Details"
            };

            if (id.HasValue)
            {
                var emp = _employeeService.GetById(id.Value);
                if (emp != null)
                {
                    vm.EmployeeId = emp.Id;
                    vm.EmployeeName = emp.Name;
                    vm.EmployeeSalary = emp.Salary;
                }
            }

            return View(vm);
        }

        //[Authorize]
        [HttpPost]
        public IActionResult Edit(EmployeeEditVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            var emp = _employeeService.GetById(vm.EmployeeId);
            if (emp != null)
            {
                emp.Name = vm.EmployeeName;
                emp.Salary = vm.EmployeeSalary;
            }

            return RedirectToAction("Index");
        }

        //[Authorize]
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                _employeeService.Remove(id.Value);
            }
            return RedirectToAction("Index");
        }
    }
}
