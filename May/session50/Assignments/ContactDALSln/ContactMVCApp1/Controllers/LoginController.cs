using ContactMVCApp1.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ContactMVCApp1.Controllers
{
    public class LoginController : Controller
    {
        public LoginController()
        {
            
        }
        [HttpGet]
        // GET: Login
        public ActionResult Index()
        {
            LoginVM vm = new LoginVM();
            vm.UserName = "Manjuanth";
            vm.UserPassword = "password";
            return View(vm);
        }
        //Post
        [HttpPost]
        public ActionResult Index(LoginVM vm)
        {
            //if (string.IsNullOrEmpty(vm.UserName) || string.IsNullOrEmpty(vm.UserPassword))
            //{
            //    vm.Title = "UserName or Password not set";
            //    return View(vm);
            //}
            if(!ModelState.IsValid)
            {
                return View(vm);
            }
            Session["userName"] = vm.UserName;
            FormsAuthentication.SetAuthCookie(vm.UserName,false);
            return RedirectToAction("ShowAll", "Contacts");
        }
    }
}