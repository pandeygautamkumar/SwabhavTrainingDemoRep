using ContactDALLib.EF;
using ContactDALLib.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
            return _context.contacts.First(c=>c.Id==id);
        }
        public void Delete(int id)
        {
            Contact _contact = GetContactById(id);
            if (_contact != null)
            {
                _context.contacts.Remove(_contact);
            }
            _context.SaveChanges();
        }
        public void UpdateContact(int id, Contact contact)
        {
            var cont = GetContactById(id);
            if (cont != null)
            {
                cont.Name = contact.Name;
                cont.Address = contact.Address;
                cont.MobileNumber = contact.MobileNumber;
            }
            _context.Entry(cont).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
