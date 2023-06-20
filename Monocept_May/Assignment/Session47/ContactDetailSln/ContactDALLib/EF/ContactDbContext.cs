
using ContactDALLib.Model;
using System.Data.Entity;

namespace ContactDALLib.EF
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext():base("name=ContactDbContext")
        {

        }
        public DbSet<Contact> contacts { get; set; }
    }
}
