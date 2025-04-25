using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Hata_Yönetimi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1: Temel Exception Handling
            /* try
             {
                 Console.WriteLine("Bir sayı girin:");
                 int sayi = Convert.ToInt32(Console.ReadLine());  // Kullanıcı hatalı giriş yaparsa hata oluşur
                 Console.WriteLine($"Girdiğiniz sayı: {sayi}");
             }
             catch (FormatException ex) // Format hatası yakalanır
             {
                 Console.WriteLine("Geçersiz format. Lütfen bir sayı girin.");
             }
             catch (Exception ex) // Diğer tüm hatalar burada yakalanır
             {
                 Console.WriteLine($"Beklenmedik bir hata oluştu: {ex.Message}");
             }
             finally
             {
                 Console.WriteLine("İşlem tamamlandı.");
             }
            */
            #endregion
            #region Örnek 2: Sıfıra Bölme Hatası
            try
            {
                Console.WriteLine("Bölünecek sayıyı girin:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bölme sayısını girin:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi1 / sayi2;  // Burada sıfıra bölme hatası alabiliriz.
                Console.WriteLine($"Sonuç: {sonuc}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra bölme hatası! Bölme sayısı sıfır olamaz.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmedik bir hata oluştu: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            #endregion
        }
    }
}
