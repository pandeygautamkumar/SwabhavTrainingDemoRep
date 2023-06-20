using EmployeCRUDApp.Models;
using EmployeCRUDApp.Services;
using EmployeCRUDApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EmployeCRUDApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public EmployeeDBService _employeeService;
        //public EmployeeInMemoryService _employeeService;
        public EmployeeController()
        {
           // _employeeService= EmployeeInMemoryService.GetInstance();
            _employeeService = new EmployeeDBService(); 
        }
        public ActionResult Index()
        {
            EmployeeIndexVM vm = new EmployeeIndexVM();
            vm.Title = "Employee Home Page";
            vm.Employees = _employeeService.GetEmployees();
            vm.Count = _employeeService.Count();
            return View(vm);
        }
        [Authorize]
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
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            _employeeService.Add(new Employee
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
            EmployeeEditVM vm=new EmployeeEditVM();
            vm.Title = "Edit Employee Details";

            Employee emp = _employeeService.GetById((int)id);
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

            _employeeService.Update(vm.EmployeeId, new Employee
            {
                Id=vm.EmployeeId,
                Name=vm.EmployeeName,
                Salary=vm.Salary
            });
            return RedirectToAction("Index");   
        }
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                _employeeService.Delete((int)id);
            }
            return RedirectToAction("Index");
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Index");
        }
    }
}