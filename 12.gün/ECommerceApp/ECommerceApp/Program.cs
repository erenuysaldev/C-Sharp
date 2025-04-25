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
            var userManager = new UserManager();
            var store = new Store();
            var cart = new Cart();
            User currentUser = null;

            // Mağaza ürünleri
            store.AddProduct(new Product("Laptop", 15000, 5));
            store.AddProduct(new Product("Klavye", 500, 15));

            Console.WriteLine("1 - Kayıt Ol\n2 - Giriş Yap");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Adınız: ");
                string ad = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Şifre: ");
                string sifre = Console.ReadLine();
                userManager.Register(ad, email, sifre);
            }

            Console.WriteLine("Giriş için email: ");
            string gEmail = Console.ReadLine();
            Console.WriteLine("Şifre: ");
            string gSifre = Console.ReadLine();
            currentUser = userManager.Login(gEmail, gSifre);

            if (currentUser != null)
            {
                store.ShowAllProducts();

                Console.Write("Sepete eklemek istediğiniz ürün adı: ");
                string urunAdi = Console.ReadLine();
                var secilenUrun = store.GetProductByName(urunAdi);
                if (secilenUrun != null)
                {
                    cart.AddToCart(secilenUrun);
                    cart.ShowCart();

                    var order = new Order(currentUser, cart.Items);
                    order.ShowOrder();
                }
                if (secilenUrun != null)
                {
                    cart.AddToCart(secilenUrun);
                    cart.ShowCart();

                    var order = new Order(currentUser, cart.Items);
                    currentUser.Orders.Add(order); // 🔥 Siparişi geçmişe ekle
                    order.ShowOrder();
                }
            }
            Console.WriteLine("Sipariş geçmişinizi görüntülemek ister misiniz? (e/h)");
            string cevap = Console.ReadLine();

            if (cevap.ToLower() == "e")
            {
                currentUser.ShowOrderHistory();
            }

        }
    }
}
