﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void methodlar
            /*
            ()
            Geriye Değer Döndürmeyen Metotlar
            Customer-- > Listele,ekle,sil,güncelle
            Void


            void CustomerList()
            {
                Console.WriteLine("Eren Uysal");
                Console.WriteLine("Eren Uysal");
                Console.WriteLine("Eren Uysal");
                Console.WriteLine("Eren Uysal");

            }
            CustomerList();



            void Sum()
            {
                int x = 1;
                int y = 2;
                int z =  x+y;
                Console.WriteLine(z);
            }
            Sum();
            */
            #endregion
            #region Geriye Değer Döndürmeyen String Parametreli Methodlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);

            //}
            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Samet", "Yıldız");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //void Sum(int number1 , int number2 , int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result );
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse yıldız";
            //}
            //CustomerName();
            //string StudentCard()
            //{
            //    string name = "Ali ";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //    Console.WriteLine(StudentCard());


            #endregion
            #region Geriye Değer String Paranetreli Döndüren Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz");
            //x= Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak Rengi Giriniz: "); 
            //z= Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));
            #endregion
            #region Geriye Değer Döndüren String Parametreli Metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));




            #endregion
            Console.Read();
        }
    }
}
