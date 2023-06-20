using ContactDALLib.EF;
using ContactDALLib.Model;
using System.Collections.Generic;
using System.Linq;


namespace ContactDALLib.Repository
{
    public class ContactRepository
    {
        private ContactDbContext _context;
        public ContactRepository()
        {
            _context = new ContactDbContext();
        }
        public void AddContact(Contact contact)
        {
            _context.contacts.Add(contact);
            _context.SaveChanges();
        }
        public List<Contact> GetContact()
        {
            return _context.contacts.ToList();
        }
    }
}
