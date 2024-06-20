using Microsoft.AspNetCore.Mvc;
using LabWebApp.Data;
using LabWebApp.Models;
using System.Linq;

namespace LabWebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
