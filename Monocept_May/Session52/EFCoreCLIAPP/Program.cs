// See https://aka.ms/new-console-template for more information
using EFCoreCLIAPP.EF;
using EFCoreCLIAPP.Model;

namespace EFCoreCLIAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monocept = new Organization { EmployeeCount = 1000, Name = "Monocept" };
            var db = new OrganizationDbContext();
            // db.Add(monocept);
            // db.SaveChanges();
            var singleOrg = db.Organizations.Single(o => o.Id == new Guid("8D014366-FE1C-45B8-8D99-08DB603A1BAC"));
            Console.WriteLine(singleOrg.Name);
            Console.WriteLine(singleOrg.EmployeeCount);
            Console.WriteLine("End");
        }
    }
}
