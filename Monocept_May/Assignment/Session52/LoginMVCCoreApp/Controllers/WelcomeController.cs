using Microsoft.AspNetCore.Mvc;
using LoginMVCCoreApp.ViewModel;
using LoginMVCCoreApp.Services;
public class WelcomeController : Controller
{
    private readonly UserService _userService;
    public WelcomeController()
    {
       _userService=UserService.GetInstance();  
    }
    public ActionResult Index(string name)
    {
        UsersVM vm=new UsersVM
        {
            User=_userService.GetByName(name),
            Users=_userService.GetAllUsers()
        };
        return View(vm);
    }
}