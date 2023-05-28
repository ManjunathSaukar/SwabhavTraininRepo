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
        private string connectionString;
        public ContactRepository(string connectionString)
        {
            this.connectionString = connectionString;
           
        }

        public void AddContact(Contact contact)
        {
            using (var context = new ContactDbContext())
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
            }
        }

        public List<Contact> GetContacts()
        {
            using (var context = new ContactDbContext())
            {
                return context.Contacts.ToList();
            }
        }
        public Contact GetContactById(int id)
        {
            using (var context = new ContactDbContext())
            {
                return context.Contacts.FirstOrDefault(c => c.Id == id);
            }
        }
        public void UpdateContact(Contact contact)
        {
            using (var context = new ContactDbContext())
            {
                var existingContact = context.Contacts.Find(contact.Id);
                if (existingContact != null)
                {
                    existingContact.Name = contact.Name;
                    existingContact.MobileNumber = contact.MobileNumber;
                    context.SaveChanges();
                }
            }
        }
        public void DeleteContact(Contact contact)
        {
            using (var context = new ContactDbContext())
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
}
