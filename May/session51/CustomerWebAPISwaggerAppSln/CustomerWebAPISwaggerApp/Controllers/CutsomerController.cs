using CustomerWebAPISwaggerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CustomerWebAPISwaggerApp.Controllers
{
    [EnableCors(origins:"*", headers:"*",methods:"*")]
    [RoutePrefix("api/v1/customer")]
    public class CutsomerController : ApiController
    {
        private static List<Customer> _customer = new List<Customer>()
        {
            new Customer{Id = 1, Name ="Manjunath" },
            new Customer{Id = 2,Name="Vikrant"}
        };

        [Route("GetallCustomers")]
        public IHttpActionResult GetAllCustomers()
        {
            return Ok(_customer);
        }
        [HttpPost]
        [Route("AddCustomer")]
        public IHttpActionResult AddCustomer(Customer customer)
        {
            _customer.Add(customer);
            return Ok();
        }
    }
}
