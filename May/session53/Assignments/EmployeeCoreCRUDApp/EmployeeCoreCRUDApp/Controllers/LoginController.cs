using EmployeeCoreCRUDApp.ViewModel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EmployeeCoreCRUDApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            LoginVM vm = new LoginVM();
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            // Perform authentication logic here

            // For simplicity, assuming authentication is successful
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, vm.Name)
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true, // Set to true if you want the cookie to persist across browser sessions
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30) // Set the cookie expiration time
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return RedirectToAction("Index", "Employee"); // Redirect to a default page
        }
    }
}
