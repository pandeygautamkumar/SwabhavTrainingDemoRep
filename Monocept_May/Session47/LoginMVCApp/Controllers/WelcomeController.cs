using LoginMVCApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace LoginMVCApp.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index(LoginVM vm)
        {
            return Content("<h1>Welcome back User : "+vm.Name+". Successfully Login.!!</h1>");
        }
    }
}