using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rastgele = new Random();
            int gizliSayi = rastgele.Next(1,101); //1-100 arası sayı
            int tahmin = 0;
            int denemeSayisi = 0;
            Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldin!");
            Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Hadi tahmin et!");

            while (tahmin != gizliSayi)
            {
                Console.Write("Tahminin: ");
                string girilen = Console.ReadLine();

                //sayıya çevirmeyi deniyelim

                bool basarili = int.TryParse(girilen, out tahmin);
                if (!basarili)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı gir");
                    continue;
                }

                denemeSayisi++;
                if (tahmin < gizliSayi)
                {
                    Console.WriteLine("Daha yüksek bir sayı dene.");
                }
                else if (tahmin > gizliSayi)
                {
                    Console.WriteLine("Daha düşük bir sayı dene");
                }
            }
            Console.WriteLine($"Tebrikler! {denemeSayisi} denemede doğru tahmin ettin!");
        }
    }
}
