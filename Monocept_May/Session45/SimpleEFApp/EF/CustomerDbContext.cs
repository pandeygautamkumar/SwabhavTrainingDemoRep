
using SimpleEFApp.Model;
using System.Data.Entity;

namespace SimpleEFApp.EF
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext():base("CustomerDbContext")
        {

        }
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Order> Orders { get; set; }    
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }  
    }
}
