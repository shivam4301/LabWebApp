using LabWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LabWebApp.Data
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Product1", Price = 10.99m, Description = "Description for Product1" },
                    new Product { Name = "Product2", Price = 20.99m, Description = "Description for Product2" },
                    new Product { Name = "Product3", Price = 30.99m, Description = "Description for Product3" }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}
