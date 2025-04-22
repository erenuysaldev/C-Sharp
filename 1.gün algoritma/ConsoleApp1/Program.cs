using System;
namespace  ConsoleApp1
{ 
class Program
    {
        static void Main(string[] args)
        {
            //iki saydnın toplamını veren uygulama yazınız
            #region 

            //int sayi1 = 32;
            //int sayi2 = 32;

            //int sonuc = sayi1 +sayi2;
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Lütfen bir sayı değeri giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen sayı2 değerini giriniz");
            //int sayi2= int.Parse(Console.ReadLine());
            //Console.WriteLine(sayi1+sayi2);
            #endregion

            //Kullanıcının girdiği iki sayının karelerinin toplamını veren uygulamayı yazınız
            #region çözüm1
            //Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int sonuc= sayi1*sayi1 + sayi2*sayi2;

            //Console.WriteLine(sonuc);
            #endregion
            #region çözüm2
            //Console.WriteLine("Lütfen birinci sayıyı giriniz ");
            //int sayi1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int sayi2= Convert.ToInt32(Console.ReadLine());
            //// Math.Pow(2, 3); 2 nin 3.kuvveti
            //double sonuc = Math.Pow(1, 2) + Math.Pow(sayi2, 2);
            //Console.WriteLine(sonuc);
            #endregion

            //1 den 10 a kadar olan sayı ve rakamların küplerininin toplamını bulan uygulamayi yazin
            #region çözüm1
            //double toplamSonucu = 0;
            //for (int i = 1;i <= 10; i++)
            //{

            //    //toplamSonucu += i * i * i;
            //    toplamSonucu += Math.Pow(i, 3);

            //}
            //Console.WriteLine(toplamSonucu);
            #endregion
            #region çözüm2
            //double toplamSonuc = 0;
            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    toplamSonuc += Math.Pow(sayac,3);
            //    //if (sayac == 10)
            //    //    break;

            //    sayac++;
            //}
            //Console.WriteLine(toplamSonuc);
            #endregion
            //Doğum tarihinden yaş hesaplama 
            #region Çözüm1
            //Console.WriteLine("Lütfen doğum tarihini giriniz");
            //DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());//Suanki zaman-dogumtarihi=yas

            //TimeSpan sonuc = DateTime.Now - dogumTarihi;
            //Console.WriteLine(sonuc.Days / 365);
            #endregion
            #region cözüm2
            //Console.WriteLine("Lütfen dogum tarihini giriniz");
            //DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            //DateTime bugun = DateTime.Now;
            //int yas = bugun.Year - dogumTarihi.Year;
            //if (dogumTarihi > bugun.AddYears(-yas))
            //    --yas;
            //Console.WriteLine(yas);

            #endregion
            //pozitif sayılarda  çarpma işlemini toplama işlemi yaparak bulma
            #region çözüm1
            Console.WriteLine("Lütfen birinci sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int carpmaSonucu = 0;
            for (int i = 0; i < sayi1; i++)
            {
                carpmaSonucu += sayi2;
            }
            Console.WriteLine($"{sayi1} X {sayi2} = {carpmaSonucu}");

            #endregion

            //sayının kaç basamaklı oldugunu bulma x"
            #region

            #endregion

        }
    }
}