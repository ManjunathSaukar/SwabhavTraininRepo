// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EFCoreCliApp.EF;
using EFCoreCliApp.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        var monocept = new Organization { EmployeeCount = 1500, Name = "MONOCEPT" };
        var db = new OrganizationDbContext();
        // db.Organizations.Add(monocept);
        // db.SaveChanges();

        var singleOrg = db.Organizations.Single(o => o.Id == new Guid("08386D94-342B-4F37-8CFC-08DB6038322C"));
        Console.WriteLine(singleOrg.Name);
        Console.WriteLine("End");
    }
}