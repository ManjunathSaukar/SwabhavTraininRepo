using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMVCApp.Controllers
{
    public class WelcomeController : Controller
    {
        public WelcomeController()
        {
            
        }
        // GET: Welcome
        public ActionResult Index()
        {
            return Content($"<h1>Welcome Back {Session["userName"]} !! Login is success</h1>");
        }
    }
}