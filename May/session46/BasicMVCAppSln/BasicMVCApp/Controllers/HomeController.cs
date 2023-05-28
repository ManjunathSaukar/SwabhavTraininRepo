using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public string Hello()
        {
            return "Hello";
        }
        public ActionResult Browse()
        {
            var company = new
            {
                Name = "Monocept",
                Location = "Hyderabad"
            };
            var random = new Random();
            int randomVal = random.Next(1, 10);
            if (randomVal >= 5)
            {
                return Json(company, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return HttpNotFound($"not a valid number generated {randomVal}");
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowStudents(string name = "Monocept")
        {
            ViewBag.Key1 = "Value1";
            ViewBag.Key2 = "Value2";
            ViewBag.Name = name;

            return View();
        }
        public ContentResult Display(int id = 0)
        {
            return Content($"<h1>Displaying details for id passed : {id}</h1>");
        }
        public ContentResult Display2(int userId = 0)
        {
            return Content($"<h1>Displaying details for id passed : {userId}</h1>");
        }
    }
}