using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp
{
    public class Order
    {
        public User Customer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(User user, List<Product> products)
        {
            Customer = user;
            Products = products;
            OrderDate = DateTime.Now;
        }

        public void ShowOrder()
        {
            Console.WriteLine($"Sipariş Sahibi: {Customer.Name}");
            Console.WriteLine($"Tarih: {OrderDate}");
            Console.WriteLine("Ürünler:");
            foreach (var product in Products)
            {
                product.ShowInfo();
            }
        }
    }
}
