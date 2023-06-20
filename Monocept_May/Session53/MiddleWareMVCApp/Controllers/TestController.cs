using Microsoft.AspNetCore.Mvc;
using MiddleWareMVCApp.Services;

namespace MiddleWareMVCApp.Controllers
{
    public class TestController : Controller
    {
        private readonly IEmailService _emailService;
        public TestController(IEmailService emailService)
        {
            Console.WriteLine("TestController Created.!!");
            _emailService = emailService;
        }
        public async  Task<IActionResult> Index()
        {
            await _emailService.SendEmail("Index of TestController", "Admin", "Index Started");
            Console.WriteLine("At the Index Controller,index Method");
            return Content("<h1>Welcome to Index of Test!!</h1>", "text/html");
        }
    }
}
