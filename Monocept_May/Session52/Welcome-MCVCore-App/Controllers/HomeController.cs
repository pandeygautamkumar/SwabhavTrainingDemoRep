using Microsoft.AspNetCore.Mvc;

namespace Welcome_MCVCore_App.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Message="Controller Say Hello to View..!!";
        return View();
    }
    public IActionResult Browse(){
        return Content("<h1>This is Browser Action.!!</h1>");
    }
}
