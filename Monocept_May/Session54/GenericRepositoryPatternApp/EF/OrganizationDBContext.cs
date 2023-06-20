using GenericRepositoryPatternApp.Model;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryPatternApp.EF
{
    public class OrganizationDBContext:DbContext
    {
        public OrganizationDBContext(DbContextOptions<OrganizationDBContext> options):base(options) 
        {
        }  
        public DbSet<Organization> Organizations { get; set; }  

    }
}
