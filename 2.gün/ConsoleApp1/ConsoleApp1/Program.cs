using System;
using System.Collections.Concurrent;
using System.Diagnostics.Metrics;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            #region bilgiler
            //bir dizi metin (char) karakteri bir araya toplayarak metinsel değerleri tutan veri tipidir
            //double = çok sayıda ondalık basamak içeren reel sayılar için kullanılır
            //var = Global / Genel değişken tipi. Bu türde değişkenlere bir değer verildiği zaman, o değerin(sayı, tarih, metin vs) formatına uygun bir tipte veri saklar.
            //int = Tam Sayı için
            //bool bir true bir false değeriçin
            //char tek bir alfasayısal karakter için
            //float = kesirli sayısal değerler için kullanılır
            //single = çok sayıda ondalık basamak içeren reel sayılar için kullanılır

            //string mesaj = "Merhaba";
            //double tutar = 10.0;
            //int sayi = 100;


            //x >  x          =         x BÜYÜKTÜR y
            //x <  y          =         x KÜÇÜKTÜR y
            //x == y          =       x EŞİTTİR y
            //x != y          =        x EŞİT DEĞİLDİR y
            //x >= y          =       x BÜYÜKTÜR VEYA EŞİTTİR y
            //x <= y          =       x KÜÇÜKTÜR VEYA EŞİTTİR y
            //x || x          =          x VEYA y(Bu işaret ALTGR ile TİRE / EKSİ işaretine basılarak yapılır)
            //x && x          =     x VE y
            #endregion
            #region Koşullar   (if else)
            //               x değeri y değerinden küçükse, “a” değerini eksi 5, değilse 5 yap)

            //     if (x < y)
            //     a = -5;
            //      else
            //     a = 5;
            //Console.WriteLine('b');  Tek tırnak işareti bir karakter değişmez değeri oluşturur.
            //   float         ~6-9 digits
            //   double        ~15-17 digits
            //   decimal        28-29 digits

            #endregion
            #region bilgi
            /*
                    Değişmez değer dizesine sekme \t, yeni satır \n veya çift tırnak işareti \" gibi bir özel karakter eklemeniz gerektiğinde karakter kaçış dizilerini kullanın.
                    Diğer tüm senaryolarda ters eğik çizgi kullanmanız gerektiğinde, ters eğik çizgi \\ için bir kaçış karakteri kullanın.
                    Dizedeki @ tüm boşluk biçimlendirmesini ve ters eğik çizgi karakterlerini tutan bir düz metin dizesi değişmez değeri oluşturmak için yönergesini kullanın.
                    Bir dizedeki Unicode karakterlerini (UTF-16) göstermek için \u ve dört karakterli kodu kullanın.
                    Unicode karakterleri uygulamaya bağlı olarak doğru yazdırılamayabilir
            */
            #endregion
            #region bob
            //string firstName = "Bob";
            //string greeting = "Hello";
            //Console.WriteLine(greeting + " " + firstName + "!");

            //int version = 11;
            //string updateText = "Update to Windows";
            //Console.WriteLine($"{updateText} {version}!");

            //string projectName = "First-Project";
            //Console.WriteLine($@"C:\Output\{projectName}\Data");
            #endregion
            #region vatandaş
            //    public class Vatandas
            //{
            //    public string Ad {  get; set; }
            //    public string Soyad { get; set; }
            //    public int DogumYili { get; set; }
            //    public long TcNo { get; set; }
            #endregion
            #region yazdırma komutları
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.Read();
            #endregion
            #region rezervasyon kartı
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "1234567890";
            //customerEmail = "a@a.com";
            //district = "kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName +  " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");

            //Console.Read();
            #endregion
            #region klavyeden ondalıklı sayı işlemleri
            //     double exam1, exam2, exam3, result;
            // Console.Write("Lütfen 1.sınav notu giriniz: ");
            //     exam1 = double.Parse(Console.ReadLine());

            // Console.Write("Lütfen 2.sınav notunu giriniz ");
            // exam2 = double.Parse(Console.ReadLine());

            // Console.Write("Lütfen 3.sınav notunu giriniz ");
            // exam3 = double.Parse(Console.ReadLine());

            // result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            // Console.WriteLine("Sınav ortalamanız: " + result);
            #endregion





        }




























    }

}


