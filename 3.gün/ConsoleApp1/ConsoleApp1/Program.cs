using System;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            #endregion
            #region baskent
            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}
            #endregion
            #region sayı
            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number=int.Parse(Console.ReadLine()); 
            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı doğru ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı ");
            //}
            #endregion
            #region sınav ortalaması
            //int exam1, exam2, exam3, average;
            //string result = "Hata!";
            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 =int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların ortalaması: " + average);
            //if(average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if(average>50  & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if(average>70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if(average>84 & average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            #endregion
            #region sehir
            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();
            //if(city== "adana" | city=="ankara" | city=="bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}
            #endregion
            #region switch case
            //Console.WriteLine("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi "); break;
            //}


            #endregion
            #region döngüler,for,while
            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for(int i = 1; i<= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz");
            //int finishValue = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion
            #region for döngüsü
            //for (int i = 1; i<= 10000; i++)
            //{
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count
            #endregion
            #region while döngüsü
            //while (Şart)
            //{
            //    Döngüler
            //}
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}
            //int i = 1;
            //while (i <= 10)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);




            #endregion
            #region yıldız yapma
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int k = 4; k >= 1; k--)
            {
                for (int m = 1; m <= k; m++)
                {
                    Console.Write("*");  // Burada Write olmalı, WriteLine değil.
                }
                Console.WriteLine();  // Yıldızları yazdırdıktan sonra bir satır atlayalım.
            }

            #endregion
            Console.Read();
        }




    }






}