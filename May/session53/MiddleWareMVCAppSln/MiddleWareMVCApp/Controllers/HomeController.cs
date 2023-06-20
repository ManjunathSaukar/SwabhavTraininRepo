using Microsoft.AspNetCore.Mvc;
using MiddleWareMVCApp.Models;
using MiddleWareMVCApp.Services;
using System.Diagnostics;

namespace MiddleWareMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailService _emailService;
        public HomeController(IEmailService emailService)
        {
            Console.WriteLine("HomeController created");
            _emailService = emailService;
        }
        public async Task<IActionResult> Index()
        {
            await _emailService.SendEmail("invoke method foo", "admin", "invoke started");
            Console.WriteLine("At Controller, index method");
            return Content("<h1>Welcome to index of Home</h1>","text/html");
        }
    }
}