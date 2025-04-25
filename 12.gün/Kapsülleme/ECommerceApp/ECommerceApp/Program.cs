using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp
{
    class Program
    {
        static void Main()
        {
            var store = new Store();
            var user = new User("Ali", "ali@example.com", "1234");
            var cart = new Cart();

            // Mağazaya ürün ekleyelim
            store.AddProduct(new Product("Laptop", 15000, 5));
            store.AddProduct(new Product("Klavye", 500, 15));

            // Ürünleri göster
            store.ShowAllProducts();

            // Sepete ürün ekleyelim
            cart.AddToCart(store.GetProductByName("Laptop"));
            cart.ShowCart();

            // Sipariş oluştur
            var order = new Order(user, cart.Items);
            order.ShowOrder();
        }
    }


}
