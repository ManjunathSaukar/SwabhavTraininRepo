using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WelcomeMVCCoreApp.Models;

namespace WelcomeMVCCoreApp.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;

    

    public IActionResult Index()
    {
        ViewBag.Message = "Controller says Hi";
        return View();
    }
    public IActionResult Browse()
    {
        return Content("This is Browse Action");
    }
    
}
