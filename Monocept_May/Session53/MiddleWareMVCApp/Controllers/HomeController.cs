using Microsoft.AspNetCore.Mvc;
using MiddleWareMVCApp.Models;
using MiddleWareMVCApp.Services;
using System.Diagnostics;

namespace MiddleWareMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailService _emailService;
        public HomeController(IEmailService emailService)
        {
            Console.WriteLine("HomeController Created.!!");
            _emailService = emailService;
        }
        public async Task<IActionResult> Index()
        {
            await _emailService.SendEmail("Index of HomeController", "Admin", "Index Started");
            Console.WriteLine("At the Home Controller,index Method");
            return Content("<h1>Welcome to Index of Home!!</h1>", "text/html");
        }
    }
}