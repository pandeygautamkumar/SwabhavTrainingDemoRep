using EmployeeCoreCRUDApp.ViewModel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EmployeeCoreCRUDApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(string ReturnUrl = "/")
        {
            LoginVM vm = new LoginVM();
            vm.Name = "Gautam";
            vm.ReturnUrl = ReturnUrl;
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginVM vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, vm.Name)
                // Add any additional claims if needed
            };
            //Initialize a new instance of the ClaimsIdentity with the claims and authentication scheme    
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            //Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity
            var principal = new ClaimsPrincipal(identity);
            //SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
            {
                IsPersistent = vm.RememberLogin
            });
            return RedirectToAction("Index", "Employee");
        }
    }
}
