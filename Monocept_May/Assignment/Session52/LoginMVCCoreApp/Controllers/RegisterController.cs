using Microsoft.AspNetCore.Mvc;
using LoginMVCCoreApp.ViewModel;
using LoginMVCCoreApp.Models;
using LoginMVCCoreApp.Services;
public class RegisterController : Controller
{
    private readonly UserService _userService;
    public RegisterController()
    {
       _userService=UserService.GetInstance();  
    }
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Index(RegisterVM vm)
    {
        if (!ModelState.IsValid)
        {
            return View(vm);
        }
        User user = new User
        {
            Id=vm.Id,
            Name = vm.Name,
            Password=vm.Password,
            Address=vm.Address
        };
        _userService.Add(user);
        return RedirectToAction("Index","Login");
    }
}