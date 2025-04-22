using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While
            //while, bir koşul doğru olduğu sürece döner
            /*
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine($"Sayı: {i}");
                i++;
            }
           ----
            int sayi = 1;

            while (sayi <= 10)
            { //1 den 10'a kadar ki tek sayıları yazdırır
                if (sayi % 2 == 1)
                {
                    Console.WriteLine($"Tek sayı: {sayi}");
                }
                sayi++;
            }
            ----
            string giris = "";
            while (giris != "çıkış")
            {
            Console.Write("Komut girin (çıkış için 'çıkış' yazın): ");
            giris = Console.ReadLine();
            Console.WriteLine($"Girdiğiniz: {giris}");
            }
           */
            #endregion
            #region Do-While
            //do-while, önce bir kez çalışır, sonra koşula bakar.
            /* int i = 1;

             do
             {
                 Console.WriteLine($"Sayı: {i}");
                 i++;
             }
             while (i <= 5);
            --------
            // En az bir kere çalışan kullanıcı onayı
            string cevap;

                do
                {
                    Console.Write("Devam etmek istiyor musunuz? (e/h): ");
                    cevap = Console.ReadLine();
                }
                while (cevap != "e" && cevap != "h");

                Console.WriteLine("Cevabınız: " + cevap);
            -------
            Şifre kontrolü
            string sifre;

                do
                {
                    Console.Write("Şifreyi girin: ");
                    sifre = Console.ReadLine();
                }
                while (sifre != "1234");

                Console.WriteLine("Şifre doğru! ✅");
            */
            #endregion
            #region Tahmin Oyunu
            /*
            Random rnd = new Random();
            int hedefSayi = rnd.Next(1, 101); // 1 ile 100 arasında sayı
            int tahmin = 0;
            int denemeSayisi = 0;

            Console.WriteLine("🎮 1 ile 100 arasında bir sayı tuttum.");
            Console.WriteLine("Tahmin etmeye çalış bakalım!");

            while (tahmin != hedefSayi)
            {
                Console.Write("Tahminin nedir? ");
                string giris = Console.ReadLine();

                // Sayıya çevir ve kontrol et
                if (!int.TryParse(giris, out tahmin))
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin!");
                    continue;
                }

                denemeSayisi++;

                if (tahmin < hedefSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı dene 🔼");
                }
                else if (tahmin > hedefSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı dene 🔽");
                }
                else
                {
                    Console.WriteLine($"\n🎉 Tebrikler! {denemeSayisi} denemede doğru bildin!");
                }
                */
            #endregion
            #region Gelişmiş Tahmin Oyunu
            bool tekrarOyna = true;

            while (tekrarOyna)
            {
                Console.Clear(); // Ekranı temizle
                Random rnd = new Random();
                int hedefSayi = rnd.Next(1, 101);
                int tahmin = 0;
                int denemeSayisi = 0;
                int maxHak = 7;

                Console.WriteLine("🎯 1 ile 100 arasında bir sayı tuttum.");
                Console.WriteLine($"Tahmin etmeye çalış! Toplam {maxHak} hakkın var.\n");

                while (tahmin != hedefSayi && denemeSayisi < maxHak)
                {
                    Console.Write($"({denemeSayisi + 1}/{maxHak}) Tahminin: ");
                    string giris = Console.ReadLine();

                    if (!int.TryParse(giris, out tahmin))
                    {
                        Console.WriteLine("🚫 Geçerli bir sayı girin!\n");
                        continue;
                    }

                    denemeSayisi++;

                    if (tahmin < hedefSayi)
                    {
                        Console.WriteLine("🔼 Daha büyük bir sayı dene.\n");
                    }
                    else if (tahmin > hedefSayi)
                    {
                        Console.WriteLine("🔽 Daha küçük bir sayı dene.\n");
                    }
                    else
                    {
                        Console.WriteLine($"\n🎉 Tebrikler! {denemeSayisi} denemede doğru bildin!");
                    }
                }

                if (tahmin != hedefSayi)
                {
                    Console.WriteLine($"\n😢 Üzgünüm, bilemedin. Doğru sayı: {hedefSayi}");
                }

                // Oyunu tekrar oynama seçeneği
                Console.Write("\n🔁 Tekrar oynamak ister misin? (e/h): ");
                string cevap = Console.ReadLine().ToLower();
                tekrarOyna = (cevap == "e");
            }

            Console.WriteLine("\n👋 Oyun bitti. Görüşmek üzere!");
            #endregion
        }
    }
}
