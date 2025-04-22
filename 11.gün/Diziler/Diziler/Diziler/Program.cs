using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region not ortalaması
            /*
            int[] notlar = { 70, 85, 90, 65, 100 };
            int toplam = 0;

            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }

            double ortalama = (double)toplam / notlar.Length;
            Console.WriteLine($"Ortalama: {ortalama}");
            */
            #endregion
            #region kullanıcıdan 5 sayı alıp en büyük sayıyı bulma
            /*
            int[] sayilar = new int[5];

            Console.WriteLine("5 sayı girin:");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"Sayı {i + 1}: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enBuyuk = sayilar[0]; // İlk elemanı varsayılan en büyük olarak kabul et

            for (int i = 1; i < sayilar.Length; i++) // 1'den başlıyoruz çünkü ilk değeri zaten aldık
            {
                if (sayilar[i] > enBuyuk)
                {
                    enBuyuk = sayilar[i];
                }
            }

            Console.WriteLine($"En büyük sayı: {enBuyuk}");
            */
            #endregion
            #region Kullanıcıdan 3 isim alıp, alfabetik sıraya göre yazdırma
            //string[] isimler = new string[3];

            //Console.WriteLine("3 isim girin:");

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.Write($"İsim {i + 1}: ");
            //    isimler[i] = Console.ReadLine();
            //}

            //Array.Sort(isimler); // Diziyi alfabetik sıraya sokar

            //Console.WriteLine("\nAlfabetik sırayla isimler:");
            //foreach (string isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            /*
             * Nasıl çalışır ?
                    3 tane isim alıyoruz ve bunları isimler dizisinde saklıyoruz.
                    Array.Sort(isimler) fonksiyonu diziyi alfabetik sıraya sokuyor.
                    Son olarak, sıralanmış diziyi ekrana yazdırıyoruz.
                */
            #endregion
            #region Kullanıcının 5 notunu alıp en küçük notu bulma
            //int[] notlar = new int[5];

            //Console.WriteLine("5 not girin:");

            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    Console.Write($"Not {i + 1}: ");
            //    notlar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int enKucuk = notlar[0]; // İlk notu varsayılan en küçük olarak kabul et

            //for (int i = 1; i < notlar.Length; i++) // 1'den başlıyoruz çünkü ilk notu zaten aldık
            //{
            //    if (notlar[i] < enKucuk)
            //    {
            //        enKucuk = notlar[i];
            //    }
            //}

            //Console.WriteLine($"En küçük not: {enKucuk}");

            #endregion
            #region Kullanıcının girdiği 10 sayının toplamını ve ortalamasını hesaplama
            int[] sayilar = new int[10];
            int toplam = 0;

            Console.WriteLine("10 sayı girin:");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"Sayı {i + 1}: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayilar[i];
            }

            double ortalama = (double)toplam / sayilar.Length;

            Console.WriteLine($"Toplam: {toplam}");
            Console.WriteLine($"Ortalama: {ortalama}");

            #endregion
        }
    }
}
