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
            int[] notlar = { 70, 85, 90, 65, 100 };
            int toplam = 0;

            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }

            double ortalama = (double)toplam / notlar.Length;
            Console.WriteLine($"Ortalama: {ortalama}");
            #endregion
        }
    }
}
