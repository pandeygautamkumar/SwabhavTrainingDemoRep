using EmployeeCoreCRUDApp.Models;

namespace EmployeeCoreCRUDApp.Services
{
    public interface IEmployeeServices
    {
        void AddEmployee(Employee emp);
        List<Employee> GetAllEmployee();
        Employee GetEmployeeByID(int id);
        int NoOfEmployee();
        void RemoveEmployee(int id);
        void UpdateEmployee(int id, Employee emp);
    }
}