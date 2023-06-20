
using System;
using System.Configuration;
using System.Web.Mvc;

namespace SimpleMvcApp.Controllers
{
    public class HomeController:Controller
    {
        public string Hello()
        {
            return "Gautam";
        }
        public ActionResult Browse()
        {
            var company = new
            {
                name = "Monocept",
                location = "Mumbai"
            };
            var random = new Random();
            int randomValue=random.Next(1,10);
            if(randomValue>= 5)
            {
                return Json(company, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return HttpNotFound("Not Valid Number Genereted Number is : "+randomValue);
            }
        }
        public ViewResult Index()
        {
            return View();
        }
        public ActionResult ShowStudent(string name="Monocept")
        {
            ViewBag.Key1 = name;
            ViewBag.Key2 = "Value2";
            return View();
        }
        public ContentResult Display(int id=0)
        {
            return Content("<h1>Details For Id Passed: "+id+" </h1>");
        }
        public ContentResult Show(int userId = 0)
        {
            return Content("<h1>Details For Id Passed: " + userId+ " </h1>");
        }
    }
}