using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleWebAPIApp.Controllers
{
    public class WelcomeController : ApiController
    {
        public WelcomeController()
        {

        }
        public string Get()
        {
            return "Get Called";
        }
        public string Post()
        {
            return "Post called";
        }
        public string Put()
        {
            return "Put called";
        }
        public string Delete()
        {
            return "Delete called";
        }
    }
}
