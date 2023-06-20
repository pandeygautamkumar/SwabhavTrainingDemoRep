using EFCoreConsoleApp.EF;
using EFCoreConsoleApp.Model;

namespace EFCoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monocept = new Organization { EmployeeCount = 1000, Name = "Monocept" };
            var db = new OrganizationDbContext();
            //db.Add(monocept);
            //db.SaveChanges();
            var singleOrg = db.Organizations.Single(o => o.Id == new Guid("36A8D957-E3B3-4BF9-6F18-08DB603496C2"));
            Console.WriteLine(singleOrg.Name);
            Console.WriteLine(singleOrg.EmployeeCount);
            Console.WriteLine("End");
        }
    }
}