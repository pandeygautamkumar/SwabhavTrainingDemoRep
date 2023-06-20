
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
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            ViewBag.key = id;
            Contact contact = _contactRepository.GetContactById((int)id);
            if (contact == null)
            {
                contact = _contactRepository.GetContactById(1);
            }
            return View(contact);
        }
        public ActionResult AddContact()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(AddVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            _contactRepository.AddContact(new Contact
            {
                Id = vm.Id,
                Name = vm.Name, 
                MobileNumber = vm.MobileNumber,
                Address = vm.Address
            });
            return RedirectToAction("GetContacts");
        }
        public ActionResult Edit(int? id)
        {
            ContactEditVM vm = new ContactEditVM();

            Contact emp = _contactRepository.GetContactById((int)id);
            vm.ID= emp.Id;
            vm.Name = emp.Name;
            vm.MobileNumber = emp.MobileNumber;
            vm.Address = emp.Address;
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View(vm);
        }
        [HttpPost]
        public ActionResult Edit(ContactEditVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            _contactRepository.UpdateContact(vm.ID, new Contact{ 
                Name = vm.Name,
                MobileNumber = vm.MobileNumber,
                Address = vm.Address
            });
            return RedirectToAction("GetContacts");
        }
        public ActionResult Delete(int? id)
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            if (id != null)
            {
                _contactRepository.Delete((int)id);
            }
            return RedirectToAction("GetContacts");
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("GetContacts");
        }
    }
}