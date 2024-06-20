using LabWebApp.Models;
using Microsoft.EntityFrameworkCore;
namespace LabWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public IConfiguration Configuration { get; set; }
        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }

        public DbSet<Product> Products { get; set; }
    }
}
