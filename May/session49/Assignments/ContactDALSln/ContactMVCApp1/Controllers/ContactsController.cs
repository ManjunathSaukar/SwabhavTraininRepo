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
            if (Session["userName"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
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

                // Redirect to the ShowAll page
                return RedirectToAction("ShowAll");
            }

            // If the model state is not valid, return the view with the view model
            return View(viewModel);
        }
        // GET: Contacts/EditContact/1
        public ActionResult EditContact(int id)
        {
            if (Session["userName"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            // Retrieve the contact based on the provided id
            var contact = contactRepository.GetContactById(id);

            // Create the view model
            var viewModel = new EditContactViewModel
            {
                Id = contact.Id,
                Name = contact.Name,
                MobileNumber = contact.MobileNumber
            };

            // Pass the view model to the view
            return View(viewModel);
        }
        // POST: Contacts/EditContact
        [HttpPost]
        public ActionResult EditContact(EditContactViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Retrieve the existing contact from the repository
                var existingContact = contactRepository.GetContactById(viewModel.Id);

                if (existingContact != null)
                {
                    // Update the contact properties
                    existingContact.Name = viewModel.Name;
                    existingContact.MobileNumber = viewModel.MobileNumber;

                    // Save the changes
                    contactRepository.UpdateContact(existingContact);

                    // Redirect to the ShowAll page
                    return RedirectToAction("ShowAll");
                }
            }

            // If the model state is not valid or the contact was not found, return the view with the view model
            return View(viewModel);
        }
        public ActionResult DeleteContact(int id)
        {
            if (Session["userName"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            // Retrieve the contact based on the provided id
            var contact = contactRepository.GetContactById(id);

            if (contact != null)
            {
                // Delete the contact from the repository
                contactRepository.DeleteContact(contact);

                // Redirect to the ShowAll action
                return RedirectToAction("ShowAll");
            }

            // If the contact was not found, return an error or redirect to an appropriate page
            return RedirectToAction("ShowAll");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("ShowAll");
        }
    }
}