
using ContactDALLib.Model;
using ContactDALLib.Repository;
using ContactMVCAppV2.ViewModel;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ContactMVCAppV2.Controllers
{
    public class ContactsController : Controller
    {
        public ContactRepository _contactRepository;
        public ContactsController()
        {
            _contactRepository = new ContactRepository();
        }
        public ActionResult GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            contacts = _contactRepository.GetContact();
            return View(contacts);
        }
        public ActionResult GetContact(int id = 1)
        {
            ViewBag.key = id;
            Contact contact = _contactRepository.GetContactById(id);
            if (contact == null)
            {
                contact = _contactRepository.GetContactById(1);
            }
            return View(contact);
        }
        public ActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(AddVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            Contact contact = new Contact();
            contact.Name = vm.Name;
            contact.MobileNumber = vm.MobileNumber;
            contact.Address = vm.Address;
            _contactRepository.AddContact(contact);
            ModelState.Clear();
            return View();
        }
    }
}