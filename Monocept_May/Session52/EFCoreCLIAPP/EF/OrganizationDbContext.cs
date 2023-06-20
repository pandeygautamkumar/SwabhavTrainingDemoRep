
using EFCoreCLIAPP.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCLIAPP.EF
{
    public class OrganizationDbContext :DbContext
    {
        public DbSet<Organization>? Organizations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=OrganizationDb;Integrated Security=True;TrustServerCertificate=True;");                //Provider or Driver 
        }
    }
}
