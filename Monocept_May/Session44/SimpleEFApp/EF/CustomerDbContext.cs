
using SimpleEFApp.Model;
using System.Data.Entity;

namespace SimpleEFApp.EF
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext():base("CustomerDbContext")
        {

        }
        public DbSet<Customer> customers { get; set; }  
    }
}
