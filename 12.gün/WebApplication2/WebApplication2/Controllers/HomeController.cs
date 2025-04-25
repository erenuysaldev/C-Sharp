using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Ürün listesi
        public IActionResult Index()
            {
                var products = _context.Products.ToList(); // Veritabanýndan ürünleri alýyoruz.
                return View(products);

            }
        
    }
}