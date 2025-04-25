using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp
{
    public class User
    {
        private string name;
        private string email;
        private string password;
        public List<Order> Orders { get; set; }

        public string Role { get; private set; } = "Customer";

        public string Name
        {
            get => name;
            set => name = value.Length >= 2 ? value : "Geçersiz ad";
        }

        public string Email
        {
            get => email;
            set => email = value.Contains("@") ? value : "gecersiz@mail.com";
        }

        public string Password
        {
            get => password;
            set => password = value.Length >= 4 ? value : "1234";
        }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ad: {Name}, Email: {Email}, Rol: {Role}");
        }
        public void ShowOrderHistory()
        {
            if (Orders.Count == 0)
            {
                Console.WriteLine("Henüz siparişiniz yok.");
                return;
            }

            Console.WriteLine("Sipariş Geçmişi:");
            foreach (var order in Orders)
            {
                order.ShowOrder();
                Console.WriteLine("------------------");
            }
        }
    }
}
