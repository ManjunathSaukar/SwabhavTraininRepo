using ContactDALLib.Repository;
using ContactMVCApp1.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactMVCApp1.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        private readonly ContactRepository contactRepository;

        public ContactsController()
        {
            // Provide the connection string to the ContactRepository
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=ContactDB;Integrated Security=True";
            contactRepository = new ContactRepository(connectionString);
        }
        // GET: Contacts/ShowAll
        public ActionResult ShowAll()
        {
            // Retrieve all contacts from the repository
            var contacts = contactRepository.GetContacts();

            // Pass the contacts to the view
            return View(contacts);
        }

        // GET: Contacts/ShowSingle/1
        public ActionResult ShowSingle(int id)
        {
            // Retrieve a single contact based on the provided id
            var contact = contactRepository.GetContactById(id);

            // Pass the contact to the view
            return View(contact);
        }
        // GET: Contacts/AddContact
        public ActionResult AddContact()
        {
            var viewModel = new AddContactViewModel();
            return View(viewModel);
        }

        // POST: Contacts/AddContact
        [HttpPost]
        public ActionResult AddContact(AddContactViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Create a new contact based on the view model data
                var contact = new ContactDALLib.Model.Contact
                {
                    Name = viewModel.Name,
                    MobileNumber = viewModel.MobileNumber
                };

                // Add the contact to the repository
                contactRepository.AddContact(contact);

                ModelState.Clear();
                return View();

            }

            // If the model state is not valid, return the view with the view model
            return View(viewModel);
        }
    }
}