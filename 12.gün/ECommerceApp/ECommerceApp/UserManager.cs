using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp
{
    public class UserManager
    {
        private List<User> users = new List<User>();

        public void Register(string name, string email, string password)
        {
            var existing = users.Find(u => u.Email == email);
            if (existing != null)
            {
                Console.WriteLine("Bu email ile zaten bir kullanıcı var!");
                return;
            }

            users.Add(new User(name, email, password));
            Console.WriteLine("Kayıt başarılı.");
        }

        public User Login(string email, string password)
        {
            var user = users.Find(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                Console.WriteLine("Giriş başarılı. Hoşgeldiniz, " + user.Name);
                return user;
            }
            else
            {
                Console.WriteLine("Giriş başarısız. Bilgileri kontrol edin.");
                return null;
            }
        }

        public void ShowAllUsers()
        {
            foreach (var user in users)
            {
                user.ShowInfo();
            }
        }
    }
}
