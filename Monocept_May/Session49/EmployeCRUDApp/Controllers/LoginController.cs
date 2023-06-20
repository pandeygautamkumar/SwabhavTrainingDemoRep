
using EmployeCRUDApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeCRUDApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginVM vm = new LoginVM();
            vm.Name = "Sachin";
            vm.UserPassword = "Sachin";
            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(LoginVM vm)
        {
            //if (string.IsNullOrEmpty(vm.Name) || string.IsNullOrEmpty(vm.UserPassword))
            //{
            //    if (string.IsNullOrEmpty(vm.Name))
            //    {
            //        vm.Title = "UserName Not Set.";
            //    }
            //    else
            //    {
            //        vm.Title = "Password Not Set.";
            //    }
            //    return View(vm);
            //}
            if(!ModelState.IsValid)
            {
                return View(vm);    
            }
            Session["username"] = vm.Name;
            return RedirectToAction("Index", "Employee");
        }
    }
}