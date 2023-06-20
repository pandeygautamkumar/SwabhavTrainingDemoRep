
using EmployeCRUDApp.Models;
using System.Collections.Generic;

namespace EmployeCRUDApp.Services
{
    public interface IEmployeeServices
    {
        List<Employee> GetEmployees();
        int Count();
        Employee GetById(int id);
        void Add(Employee employee);
        void Delete(int id);
        void Update(int id, Employee employee);
    }
}