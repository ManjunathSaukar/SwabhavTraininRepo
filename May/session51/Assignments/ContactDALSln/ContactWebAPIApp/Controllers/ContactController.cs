using ContactDALLib.Model;
using ContactDALLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ContactWebAPIApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/v1/contact")]
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            contactRepository = new ContactRepository();
        }

        [HttpGet]
        [Route("GetAllContacts")]
        public IHttpActionResult GetAllContacts()
        {
            List<Contact> contacts = contactRepository.GetContacts();
            return Ok(contacts);
        }

        [HttpGet]
        [Route("GetContactById/{id}")]
        public IHttpActionResult GetContactById(int id)
        {
            Contact contact = contactRepository.GetContactById(id);
            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [HttpPost]
        [Route("AddContact")]
        public IHttpActionResult AddContact(Contact contact)
        {
            contactRepository.AddContact(contact);
            return Ok();
        }

        [HttpPut]
        [Route("UpdateContact")]
        public IHttpActionResult UpdateContact(Contact contact)
        {
            contactRepository.UpdateContact(contact);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteContact/{id}")]
        public IHttpActionResult DeleteContact(int id)
        {
            Contact contact = contactRepository.GetContactById(id);
            if (contact == null)
                return NotFound();

            contactRepository.DeleteContact(contact);
            return Ok();
        }
    }
}
