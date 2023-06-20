
using ContactMVCAppV2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ContactMVCAppV2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginVM vm = new LoginVM();
            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(LoginVM vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);    
            }
            Session["username"] = vm.Name;
            FormsAuthentication.SetAuthCookie(vm.Name, false);
            return RedirectToAction("GetContacts", "Contacts");
        }
    }
}