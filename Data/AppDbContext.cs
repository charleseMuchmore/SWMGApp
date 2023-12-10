using Microsoft.EntityFrameworkCore;
using SWMGApp.Models;

namespace SWMGApp.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        // one DbSet for each domain model class
        public DbSet<Company> Companies { get; set; }
        
        public DbSet<Help> Help { get; set; }

        public DbSet<Industry> Industries { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Newsletter> Newsletters { get; set; }




    }
}
