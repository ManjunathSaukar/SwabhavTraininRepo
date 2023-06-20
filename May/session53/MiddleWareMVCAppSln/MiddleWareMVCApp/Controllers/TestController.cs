using Microsoft.AspNetCore.Mvc;
using MiddleWareMVCApp.Services;

namespace MiddleWareMVCApp.Controllers
{
    public class TestController : Controller
    {
        private readonly IEmailService _emailService;
        public TestController(IEmailService emailService)
        {
            Console.WriteLine("TestController created");
            _emailService = emailService;
        }
        public IActionResult Index()
        {
            
            return Content("<h1>Index of Test Controller</h1>", "text/html");
        }
    }
}
