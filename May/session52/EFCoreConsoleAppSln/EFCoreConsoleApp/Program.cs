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
            //db.Organizations.Add(monocept);
            //db.SaveChanges();

            var singleOrg = db.Organizations.Single(o => o.Id == new Guid("F53228B1-5ECD-4FE6-E731-08DB6034B414"));
            Console.WriteLine(singleOrg.Name);
            Console.WriteLine("End");
        }
    }
}