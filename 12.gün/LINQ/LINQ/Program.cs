using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        public static void Main()
        {
            #region LINQ Query Syntax:
            /*
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var ciftSayilar = from sayi in sayilar
                              where sayi % 2 == 0  // Çift sayıları seçiyoruz
                              select sayi;

            foreach (var sayi in ciftSayilar)
            {
                Console.WriteLine(sayi);
            }
        }
            */
            #endregion
            #region LINQ Method Syntax:
            /*
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var ciftSayilar = sayilar.Where(sayi => sayi % 2 == 0);  // LINQ Method Syntax

            foreach (var sayi in ciftSayilar)
            {
                Console.WriteLine(sayi);
            }
            Where() metodu, select ifadesinin yerini alır ve istediğiniz koşulu belirlemenizi sağlar.
            */
            #endregion
            #region LINQ Ozellikleri
            /*
              Filtreleme (Where): Veriyi belirli bir koşula göre filtreler.

                Sıralama (OrderBy, OrderByDescending): Veriyi sıralar.

                Gruplama (GroupBy): Veriyi gruplar.

                Birleştirme (Join): Farklı koleksiyonları birleştirir.

                Seçim (Select): Verinin bir kısmını seçer ya da dönüştürür.

                Toplama (Sum, Average, Count): Veriyi özetler.
             */
            #endregion
            #region Örnekler
            //1.Sıralama:
            /*
            List<int> sayilar = new List<int> { 1, 8, 3, 7, 2, 9, 4 };

            var siraliSayilar = sayilar.OrderBy(sayi => sayi);  // Küçükten büyüğe sıralama

            foreach (var sayi in siraliSayilar)
            {
                Console.WriteLine(sayi);
            }
            //2. Gruplama:
            List<string> sehirler = new List<string> { "Ankara", "İstanbul", "İzmir", "Antalya", "Bursa" };

            var gruplar = sehirler.GroupBy(sehir => sehir.Length);

            foreach (var grup in gruplar)
            {
                Console.WriteLine($"Uzunluk {grup.Key} olan şehirler:");
                foreach (var sehir in grup)
                {
                    Console.WriteLine(sehir);
                }
            }
           // 3. Birleştirme (Join):
            var urunler = new List<(int UrunID, string UrunAd)> 
            {
                (1, "Laptop"),
                (2, "Klavye"),
                (3, "Fare")
            };

            var siparisler = new List<(int SiparisID, int UrunID, string MüşteriAd)> 
            {
                (1, 1, "Ali"),
                (2, 2, "Veli"),
                (3, 1, "Ahmet")
            };

            var siparislerVeUrunler = from s in siparisler
                                      join u in urunler on s.UrunID equals u.UrunID
                                      select new { s.SiparisID, s.MüşteriAd, u.UrunAd };

            foreach (var siparis in siparislerVeUrunler)
            {
                Console.WriteLine($"Sipariş ID: {siparis.SiparisID}, Müşteri: {siparis.MüşteriAd}, Ürün: {siparis.UrunAd}");
            }
            */
            #endregion
        }
    }
}