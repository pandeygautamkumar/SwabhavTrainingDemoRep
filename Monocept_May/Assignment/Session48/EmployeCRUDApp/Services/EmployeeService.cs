

using EmployeCRUDApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeCRUDApp.Services
{
    public class EmployeeService
    {
        public static EmployeeService employeeService;
        public List<Employee> _employees = new List<Employee>();
        private EmployeeService()
        {
            _employees.Add(new Employee { Id = 1, Name = "Anikant", Salary = 40000 });
            _employees.Add(new Employee { Id = 2, Name = "Vikrant", Salary = 30000 });
        }
        public static EmployeeService GetInstance()
        {
            if (employeeService == null)
            {
                employeeService=new EmployeeService();
            }
            return employeeService;
        }
        public List<Employee> GetEmployees()
        {
            return _employees;
        }
        public int Count()
        {
            return _employees.Count;    
        }
        public Employee GetById(int id)
        {
            return _employees.First(e => e.Id == id);
        }
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }
        public void Update(int id, Employee employee)
        {
            var emp=GetById(id);
            if(emp != null)
            {
                emp.Salary= employee.Salary;
                emp.Name= employee.Name;
            }
        }
    }
}