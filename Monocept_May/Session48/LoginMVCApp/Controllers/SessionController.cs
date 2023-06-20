
using System.Web.Mvc;

namespace LoginMVCApp.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            Session["Counter"] = (int)Session["Counter"] + 1;
            return View();
        }
    }
}