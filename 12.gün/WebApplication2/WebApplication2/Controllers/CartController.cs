using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CartController : Controller
    {
        private static Cart _cart = new Cart();
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AddToCart(int productId)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == productId);

            if (product != null)
            {
                var item = _cart.Items.FirstOrDefault(i => i.Product.Id == productId);
                if (item == null)
                {
                    _cart.Items.Add(new CartItem { Product = product, Quantity = 1 });
                }
                else
                {
                    item.Quantity++;
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
