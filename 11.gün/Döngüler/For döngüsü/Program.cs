using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sayıyı 5 kere yazdır
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Sayı: {i}");
            //}
            #endregion
            #region kullanıcı adını 5 kere yazdır
            //Console.Write("Adınızı girin: ");
            //string ad = Console.ReadLine();

            //Console.WriteLine($"\n{ad} ismini 5 kez yazdırıyoruz:\n");

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"{i}. {ad}");
            //}
            #endregion
            #region kullanıcının belirttiği kadar isim yazma
            Console.Write("Adınızı girin: ");
            string ad = Console.ReadLine();

            Console.Write("Kaç kere yazdırmak istersiniz? ");
            int tekrarSayisi;

            try
            {
                tekrarSayisi = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ Geçersiz sayı girdiniz.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{ad} ismini {tekrarSayisi} kez yazdırıyoruz:\n");

            for (int i = 1; i <= tekrarSayisi; i++)
            {
                Console.WriteLine($"{i}. {ad}");
            }

            Console.ResetColor();
            #endregion
          
        }
    }
}
