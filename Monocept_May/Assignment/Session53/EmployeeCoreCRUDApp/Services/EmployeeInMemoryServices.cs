using EmployeeCoreCRUDApp.Models;

namespace EmployeeCoreCRUDApp.Services
{
    public class EmployeeInMemoryServices : IEmployeeServices
    {
        public List<Employee> _emp = new List<Employee>();
        public EmployeeInMemoryServices()
        {
            Console.WriteLine("EmployeeInMemmory Service Called.");
            _emp.Add(new Employee { Id = 1, Name = "Gautam", Salary = 45000 });
            _emp.Add(new Employee { Id = 2, Name = "Manjunath", Salary = 75000 });
        }
        public List<Employee> GetAllEmployee()
        {
            return _emp;
        }
        public Employee GetEmployeeByID(int id)
        {
            Employee emp = _emp.First(e => e.Id == id);
            return emp;
        }
        public int NoOfEmployee()
        {
            return _emp.Count();
        }
        public void AddEmployee(Employee emp)
        {
            if (emp == null)
            {
                return;
            }
            _emp.Add(emp);
        }
        public void RemoveEmployee(int id)
        {
            Employee emp = GetEmployeeByID(id);
            _emp.Remove(emp);
        }
        public void UpdateEmployee(int id, Employee emp)
        {
            Employee employee = GetEmployeeByID(id);
            if (employee != null)
            {
                employee.Id = emp.Id;
                employee.Name = emp.Name;
                employee.Salary = emp.Salary;
            }
        }
    }
}
