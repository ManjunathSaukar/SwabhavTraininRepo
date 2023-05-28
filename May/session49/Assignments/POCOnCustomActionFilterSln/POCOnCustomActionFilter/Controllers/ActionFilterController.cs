using POCOnCustomActionFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POCOnCustomActionFilter.Controllers
{
    public class ActionFilterController : Controller
    {
        [LogThisRequest]
        public ActionResult YourAction()
        {
            // Your action logic here
            return View();
        }
    }
}