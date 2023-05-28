using ContactDALLib.EF;
using ContactDALLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDALLib.Repository
{
    public class ContactRepository
    {
        private ContactDbContext context;

        public ContactRepository()
        {
            context = new ContactDbContext();
        }

        public void AddContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
        }

        public List<Contact> GetContacts()
        {
            return context.Contacts.ToList();
        }

        public Contact GetContactById(int id)
        {
            return context.Contacts.FirstOrDefault(c => c.Id == id);
        }

        public void UpdateContact(Contact contact)
        {
            var existingContact = context.Contacts.Find(contact.Id);
            if (existingContact != null)
            {
                existingContact.Name = contact.Name;
                existingContact.MobileNumber = contact.MobileNumber;
                context.SaveChanges();
            }
        }

        public void DeleteContact(Contact contact)
        {
            var existingContact = context.Contacts.Find(contact.Id);
            if (existingContact != null)
            {
                context.Contacts.Remove(existingContact);
                context.SaveChanges();
            }
        }
    }
}
