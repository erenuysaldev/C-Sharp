using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp
{
    public class Store
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void ShowAllProducts()
        {
            Console.WriteLine("Tüm Ürünler:");
            foreach (var product in Products)
            {
                product.ShowInfo();
            }
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public Product GetProductByName(string name)
        {
            return Products.Find(p => p.Name.ToLower() == name.ToLower());
        }
    }
}
