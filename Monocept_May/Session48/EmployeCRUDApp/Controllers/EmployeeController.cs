using EmployeCRUDApp.Services;
using EmployeCRUDApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace EmployeCRUDApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public EmployeeService _employeeService;
        public EmployeeController()
        {
            EmployeeService.GetInstance();
        }
        public ActionResult Index()
        {
            EmployeeIndexVM vm = new EmployeeIndexVM();
            vm.Count = _employeeService.Count();
            return View(vm);
        }
        [HttpGet]
        public ActionResult Add()
        {
            EmployeeIndexVM vm = new EmployeeIndexVM();
            vm.Title = "Add Employee Form";
            return View(vm);
        }
        [HttpPost]
        public ActionResult Add(EmployeeAddVM vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }
            _employeeService.Add(new Models.Employee
            {
                Id=vm.EmployeeID,
                Name=vm.EmployeeName,
                Salary=vm.EmployeeSalary
            });
            return RedirectToAction("Index");
        }
    }
}