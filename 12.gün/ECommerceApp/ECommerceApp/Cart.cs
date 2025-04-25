using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp
{
    public class Cart
    {
        public List<Product> Items { get; set; } = new List<Product>();

        public void AddToCart(Product product)
        {
            Items.Add(product);
            Console.WriteLine($"{product.Name} sepete eklendi.");
        }

        public void ShowCart()
        {
            Console.WriteLine("Sepetinizdeki ürünler:");
            foreach (var item in Items)
            {
                item.ShowInfo();
            }
        }
    }
}
