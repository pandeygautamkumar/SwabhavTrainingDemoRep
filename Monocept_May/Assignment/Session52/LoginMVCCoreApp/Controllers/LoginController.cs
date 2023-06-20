using Microsoft.AspNetCore.Mvc;
using LoginMVCCoreApp.ViewModel;
using LoginMVCCoreApp.Services;
using LoginMVCCoreApp.Models;
public class LoginController : Controller
{
    private readonly UserService _userService;
    public LoginController()
    {
       _userService=UserService.GetInstance();  
    }
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Index(LoginVM vm)
    {
        if(!ModelState.IsValid)
        {
            return View(vm);    
        }
        User user=_userService.GetByName(vm.UserName);
        if(vm.UserName!=user.Name || vm.Password!=user.Password){
            return RedirectToAction("Index", "Login");
        }
        // Session["username"] = vm.Name;
        // FormsAuthentication.SetAuthCookie(vm.Name,false);
        //return RedirectToAction("Index", "Employee");
         return RedirectToAction("Index", "Welcome",new {name=user.Name});
    }
    public ActionResult LogOut()
    {
        return RedirectToAction("Index","Login");
    }
}