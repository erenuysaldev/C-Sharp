using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Boyutlu_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Küçük Örnek: Öğrencilerin Notları
            //    int[,] ogrenciNotlari = {
            //    {85, 90, 88},  // Öğrenci 1
            //    {75, 80, 95},  // Öğrenci 2
            //    {92, 89, 85}   // Öğrenci 3
            //};

            //    // Öğrenci notlarını yazdıralım
            //    for (int i = 0; i < ogrenciNotlari.GetLength(0); i++) // Öğrenciler
            //    {
            //        Console.WriteLine($"Öğrenci {i + 1}:");
            //        for (int j = 0; j < ogrenciNotlari.GetLength(1); j++) // Dersler
            //        {
            //            Console.WriteLine($"Ders {j + 1}: {ogrenciNotlari[i, j]}");
            //        }
            //        Console.WriteLine();
            //  }
            #endregion
            #region Restoran Menü
            string[,] menu = {
            {"Pizza", "Hamburger", "Pasta"},
            {"Kola", "Su", "Meyve Suyu"},
            {"Çikolatalı Kek", "Dondurma", "Tiramisu"}
        };

            Console.WriteLine("Restoran Menüsü:\n");

            // Menüdeki yemekleri yazdırma
            for (int i = 0; i < menu.GetLength(0); i++) // Kategoriler
            {
                Console.WriteLine(i == 0 ? "Yemekler:" : i == 1 ? "İçecekler:" : "Tatlılar:");

                for (int j = 0; j < menu.GetLength(1); j++) // Öğünler
                {
                    Console.WriteLine($"  {menu[i, j]}");
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}
