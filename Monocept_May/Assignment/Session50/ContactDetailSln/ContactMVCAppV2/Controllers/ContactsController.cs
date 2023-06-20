
using ContactDALLib.Model;
using ContactDALLib.Repository;
using ContactMVCAppV2.ViewModel;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;
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
            Session["users"] = contacts;
            return View(contacts);
        }
        [Authorize]
        public ActionResult GetContact(int? id)
        {
            Contact contact = _contactRepository.GetContactById((int)id);
            if (Session["users"] != null)
            {
                Session["users"] = _contactRepository.GetContact();
            }
            return View(contact);
        }
        [Authorize]
        public ActionResult AddContact()
        {
            if (Session["users"] != null)
            {
                Session["users"] = _contactRepository.GetContact();
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
        [Authorize]
        public ActionResult Edit(int? id)
        {
            ContactEditVM vm = new ContactEditVM();

            Contact emp = _contactRepository.GetContactById((int)id);
            vm.ID= emp.Id;
            vm.Name = emp.Name;
            vm.MobileNumber = emp.MobileNumber;
            vm.Address = emp.Address;
            if (Session["users"] != null)
            {
                Session["users"] = _contactRepository.GetContact();
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
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                _contactRepository.Delete((int)id);
            }
            if (Session["users"] != null)
            {
                Session["users"] = _contactRepository.GetContact();
            }
            return RedirectToAction("GetContacts");
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session["username"] = null;
            Session["users"] = null;
            return RedirectToAction("GetContacts");
        }
    }
}