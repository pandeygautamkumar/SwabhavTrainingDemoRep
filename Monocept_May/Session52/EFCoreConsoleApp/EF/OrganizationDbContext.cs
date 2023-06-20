
using EFCoreConsoleApp.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsoleApp.EF
{
    public class OrganizationDbContext :DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=OrganizationDb;Integrated Security=True;TrustServerCertificate=True;");                //Provider or Driver 
        }
    }
}
