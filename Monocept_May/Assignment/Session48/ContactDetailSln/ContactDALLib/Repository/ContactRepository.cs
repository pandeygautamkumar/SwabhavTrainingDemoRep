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
        public Contact GetContactById(int id)
        {
            return _context.contacts.Where(c=>c.Id==id).FirstOrDefault();
        }
    }
}
