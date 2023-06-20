using EFCoreCliApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCliApp.EF
{
    public class OrganizationDbContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=OrganizationDB;Integrated Security=True;TrustServerCertificate=True"); //Provider, driver
        }
    }
}
