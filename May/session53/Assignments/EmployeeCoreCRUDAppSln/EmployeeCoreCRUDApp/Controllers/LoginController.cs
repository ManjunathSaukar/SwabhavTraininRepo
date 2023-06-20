using EmployeeCoreCRUDApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCoreCRUDApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            LoginVM vm = new LoginVM();
            vm.Title = "Login";
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(LoginVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            // Perform authentication logic here

            // For simplicity, assuming authentication is successful
            // Set the username in session
            HttpContext.Session.SetString("UserName", vm.UserName);

            return RedirectToAction("Index", "Employee"); // Redirect to a default page
        }

    }
}
