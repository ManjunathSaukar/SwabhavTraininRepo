using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LoginMVCApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Application["counter"] = 0;
        }
        protected void Session_Start()
        {
            Session["counter"] = 0;
            Session["cart"] = null;
            Session["userName"] = null;

        }
    }
}
