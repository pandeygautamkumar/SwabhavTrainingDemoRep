using EmployeCRUDApp.Models;
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
            _employeeService=EmployeeService.GetInstance();
        }
        public ActionResult Index()
        {
            EmployeeIndexVM vm = new EmployeeIndexVM();
            vm.Title = "Employee Home Page";
            vm.Employees = _employeeService.GetEmployees();
            vm.Count = _employeeService.Count();
            return View(vm);
        }
        [HttpGet]
        public ActionResult Add()
        {
            EmployeeAddVM vm = new EmployeeAddVM();
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
            _employeeService.Add(new Employee
            {
                Id=vm.EmployeeID,
                Name=vm.EmployeeName,
                Salary=vm.EmployeeSalary
            });
            return RedirectToAction("Index");
        }
    }
}