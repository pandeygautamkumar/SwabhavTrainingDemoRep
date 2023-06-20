
using EmployeCRUDApp.Models;
using System.Data.Entity;

namespace EmployeCRUDApp.EF
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext():base("EmployeeDbContext")
        {

        }
        public DbSet<Employee> Employees { get; set; }  
    }
}