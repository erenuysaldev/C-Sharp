using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        #region toplama
        //static int Topla(int a, int b)
        //{
        //    return a + b;
        //}

        //static void Main()
        //{
        //    int sonuc = Topla(5, 7);
        //    Console.WriteLine("Toplam: " + sonuc);
        //}
        #endregion
        #region çarpma
        //static int Carp(int a, int b)
        //{
        //    return a * b;
        //}

        //static void Main()
        //{
        //    int sonuc = Carp(4, 5);
        //    Console.WriteLine("Çarpım: " + sonuc); // 20
        //}

        #endregion
        #region selamla
        //static void Selamla(string isim)
        //{
        //    Console.WriteLine("Merhaba " + isim + "!");
        //}

        //static void Main()
        //{
        //    Selamla("Ahmet");
        //    Selamla("Zeynep");
        //}

        #endregion
        #region parametresiz method
        //static void GununMesaji()
        //{
        //    Console.WriteLine("Bugün harika bir gün!");
        //}
        #endregion
        #region Büyük sayı methodu
        // BuyukSayi metodu: İki sayıdan büyük olanı döndürür
        //static int BuyukSayi(int a, int b)
        //{
        //    if (a > b)
        //    {
        //        return a;
        //    }
        //    else
        //    {
        //        return b;
        //    }
        //}

        //static void Main()
        //{
        //    // Test
        //    int sayi1 = 10;
        //    int sayi2 = 15;

        //    int buyuk = BuyukSayi(sayi1, sayi2);
        //    Console.WriteLine("Büyük sayı: " + buyuk);
        //}
        #endregion
        #region CiftMiMethodu
        // CiftMi metodu: Sayı çiftse true, tekse false döndürür
        //static bool CiftMi(int sayi)
        //{
        //    return sayi % 2 == 0; // Sayı 2'ye bölünebiliyorsa çift demektir
        //}

        //static void Main()
        //{
        //    // Test
        //    int sayi = 8;

        //    bool sonuc = CiftMi(sayi);
        //    if (sonuc)
        //    {
        //        Console.WriteLine(sayi + " bir çifttir.");
        //    }
        //    else
        //    {
        //        Console.WriteLine(sayi + " bir tektir.");
        //    }
        //}
        #endregion
        #region KareAl Methodu
        // KareAl metodu: Sayının karesini hesaplayıp ekrana yazdırır
        //static void KareAl(int sayi)
        //{
        //    int kare = sayi * sayi;
        //    Console.WriteLine(sayi + " sayısının karesi: " + kare);
        //}

        //static void Main()
        //{
        //    // Test
        //    int sayi = 5;

        //    KareAl(sayi); // 5'in karesi hesaplanıp yazdırılır
        //}
        #endregion
        #region Karekök Methodu
        // Karekok metodu: Sayının karekökünü hesaplar
        //static double Karekok(int sayi)
        //{
        //    return Math.Sqrt(sayi); // Math.Sqrt ile karekök hesaplanır
        //}

        //static void Main()
        //{
        //    // Test
        //    int sayi = 102;

        //    double sonuc = Karekok(sayi);
        //    Console.WriteLine(sayi + " sayısının karekökü: " + sonuc);
        //}
        #endregion
        #region Bir sayı üzerinden birden fazla işlem yapma
        // BuyukSayi metodu: İki sayıdan büyük olanı döndürür
        static int BuyukSayi(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // CiftMi metodu: Sayı çiftse true, tekse false döndürür
        static bool CiftMi(int sayi)
        {
            return sayi % 2 == 0;
        }

        // KareAl metodu: Sayının karesini hesaplayıp ekrana yazdırır
        static void KareAl(int sayi)
        {
            int kare = sayi * sayi;
            Console.WriteLine(sayi + " sayısının karesi: " + kare);
        }

        // Karekok metodu: Sayının karekökünü hesaplar
        static double Karekok(int sayi)
        {
            return Math.Sqrt(sayi);
        }

        static void Main()
        {
        //    // Kullanıcıdan sayı alıyoruz
        //    Console.WriteLine("Bir sayı girin: ");
        //    int sayi = Convert.ToInt32(Console.ReadLine());

        //    // Kullanıcıdan başka bir sayı alıyoruz
        //    Console.WriteLine("Karşılaştırmak için başka bir sayı girin: ");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    // BuyukSayi metodunu kullanarak büyük sayıyı buluyoruz
        //    int buyuk = BuyukSayi(sayi, sayi2);
        //    Console.WriteLine("Büyük sayı: " + buyuk);

        //    // CiftMi metodunu kullanarak sayının çift mi olduğunu kontrol ediyoruz
        //    if (CiftMi(sayi))
        //    {
        //        Console.WriteLine(sayi + " sayısı çifttir.");
        //    }
        //    else
        //    {
        //        Console.WriteLine(sayi + " sayısı tektir.");
        //    }

        //    // KareAl metodunu kullanarak sayının karesini hesaplıyoruz
        //    KareAl(sayi);

        //    // Karekok metodunu kullanarak sayının karekökünü hesaplıyoruz
        //    double karekokSonuc = Karekok(sayi);
        //    Console.WriteLine(sayi + " sayısının karekökü: " + karekokSonuc);
        //}
        #endregion
    }
}
