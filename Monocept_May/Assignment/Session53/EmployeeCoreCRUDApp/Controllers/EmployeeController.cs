using EmployeeCoreCRUDApp.Models;
using EmployeeCoreCRUDApp.Services;
using EmployeeCoreCRUDApp.ViewModel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeCoreCRUDApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices _empService;
        public EmployeeController(IEmployeeServices empService)
        {
            _empService = empService;
        }
        public IActionResult Index()
        {
            EmployeeDetailsVM vm = new EmployeeDetailsVM();
            vm.Employees = _empService.GetAllEmployee();
            vm.EmployeeCount = _empService.NoOfEmployee();
            return View(vm);
        }
        [HttpGet]
        [Authorize]
        public ActionResult Add()
        {
            EmployeeVM vm = new EmployeeVM();
            return View(vm);
        }
        [HttpPost]
        public ActionResult Add(EmployeeVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            _empService.AddEmployee(new Employee
            {
                Id = vm.EmployeeID,
                Name = vm.EmployeeName,
                Salary = vm.EmployeeSalary
            });
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Edit(int? id)
        {
            EmployeeEditVM vm = new EmployeeEditVM();

            Employee emp = _empService.GetEmployeeByID((int)id);
            vm.EmployeeId = emp.Id;
            vm.EmployeeName = emp.Name;
            vm.Salary = emp.Salary;
            return View(vm);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeEditVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            _empService.UpdateEmployee(vm.EmployeeId, new Employee
            {
                Id = vm.EmployeeId,
                Name = vm.EmployeeName,
                Salary = vm.Salary
            });
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                _empService.RemoveEmployee((int)id);
            }
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> LogOut()
        { 
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}
