using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAnnotationPOC.Controllers
{
    public class WelcomeController : Controller
    {
        public WelcomeController()
        {

        }
        // GET: Welcome
        public ActionResult Create()
        {
            return Content("<h1>Welcome Back Student !! Login is success</h1>");
        }
    }
}