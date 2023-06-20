

using EmployeCRUDApp.Migrations;
using EmployeCRUDApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeCRUDApp.EF.Repository
{
    public class EmployeeRepositoary
    {
        private EmployeeDBContext _dbContext;
        public EmployeeRepositoary()
        {
            _dbContext = new EmployeeDBContext();
        }
        public List<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }
        public int Count()
        {
            return _dbContext.Employees.Count();
        }
        public Employee GetById(int id)
        {
            return _dbContext.Employees.SingleOrDefault(e => e.Id == id);   
        }
        public void Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var emp = GetById(id);
            _dbContext.Employees.Remove(emp);
            _dbContext.SaveChanges();
        }
        public void Update(int id, Employee employee)
        {
            var emp = GetById(id);
            if (emp != null)
            {
                emp.Id = employee.Id;
                emp.Salary = employee.Salary;
                emp.Name = employee.Name;
            }
            _dbContext.SaveChanges();
        }
    }
}