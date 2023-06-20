
using ContactDALLib.Model;
using ContactDALLib.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ContactMVCAppV1.Controllers
{
    public class ContactsController : Controller
    {
        public ContactRepository _contactRepository;
        public ContactsController()
        {
            _contactRepository = new ContactRepository();
        }
        public ActionResult ShowAll()
        {
            List<Contact> contacts = new List<Contact>();
            contacts = _contactRepository.GetContact();
            return View(contacts);
        }
        public ActionResult ShowSingle(int id = 1)
        {
            ViewBag.key = id;
            Contact contact = _contactRepository.GetContactById(id);
            if (contact == null)
            {
                contact = _contactRepository.GetContactById(1);
            }
            return View(contact);
        }
    }
}