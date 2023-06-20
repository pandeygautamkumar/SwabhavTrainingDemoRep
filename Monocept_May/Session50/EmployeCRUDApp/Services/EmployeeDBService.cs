
using EmployeCRUDApp.EF.Repository;
using EmployeCRUDApp.Models;
using System.Collections.Generic;

namespace EmployeCRUDApp.Services
{
    public class EmployeeDBService : IEmployeeServices
    {
        private EmployeeRepositoary _repository;
        public EmployeeDBService()
        {
            _repository = new EmployeeRepositoary();
        }   
        public void Add(Employee employee)
        {
            _repository.Add(employee);
        }

        public int Count()
        {
            return _repository.Count();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Employee GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Employee> GetEmployees()
        {
            return _repository.GetEmployees();
        }

        public void Update(int id, Employee employee)
        {
            _repository.Update(id, employee);   
        }
    }
}