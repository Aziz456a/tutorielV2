using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;


namespace site.DAL
{
    public class DataContextFactory : IDesignTimeDbContextFactory<siteContext>
    {
        public siteContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<siteContext>();

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MySiteDB;Trusted_Connection=True; MultipleActiveResultSets = true");
            return new siteContext(optionsBuilder.Options);
        }
    }
}
