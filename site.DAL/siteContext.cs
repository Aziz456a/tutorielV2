using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using site.BL;

namespace site.DAL
{
    public class siteContext:DbContext
    {
        
            public DbSet<Blog>? Blogs { get; set; }
            public DbSet<Post>? Posts { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
       //optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MySiteDB;Integrated Security = true") ;
       //}
         public siteContext(DbContextOptions<siteContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }



    }
}
 