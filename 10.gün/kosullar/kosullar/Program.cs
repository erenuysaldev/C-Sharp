//using System;

//class Program
//{
//    static void Main()
//    {
        #region yaş
        /*
        Console.Write("Adınızı Girin : ");
        string ad = Console.ReadLine();

        Console.Write("Yaşınızı girin: ");
        string giris = Console.ReadLine();
        int yas = Convert.ToInt32(giris);

        if (yas < 12)
        {
            Console.WriteLine($"Merhaba {ad}, çocuk sayılırsın.");
        }
        else if (yas == 12)
        {
            Console.WriteLine($"Merhaba {ad}, 12 yaşındasın.");
        }
        else if (yas < 18)
        {
            Console.WriteLine($"Merhaba {ad}, reşit değilsiniz.");
        }
        else if (yas >= 18 && yas < 65)
        {
            Console.WriteLine($"Merhaba {ad}, yetişkin bir bireysiniz.");
        }
        else
        {
            Console.WriteLine($"Merhaba {ad}, emeklilik yaşındasınız.");
        }
    }
        */
        #endregion
        #region dogum yılından yaş
        /*
        Console.WriteLine("Lütfen yaşınızı girin:");
        int yas = Convert.ToInt32(Console.ReadLine());

        int dogumYili = DateTime.Now.Year - yas;
        Console.WriteLine($"Doğum yılınız: {dogumYili}");
        */
        #endregion
        #region Yaş gruplarında göre hitap
        //Console.WriteLine("Yaşınızı girin: ");
        //        int yas = Convert.ToInt32(Console.ReadLine());

        //        if (yas >= 0 && yas <= 6)
        //        {
        //            Console.WriteLine("Bebek");
        //        }
        //        else if (yas >= 7 && yas <= 12)
        //        {
        //            Console.WriteLine("Çocuk");
        //        }
        //        else if (yas >= 13 && yas <= 17)
        //        {
        //            Console.WriteLine("Ergen");
        //        }
        //        else if (yas >= 18 && yas <= 30)
        //        {
        //            Console.WriteLine("Genç yetişkin");
        //        }
        //        else if (yas >= 31 && yas <= 64)
        //        {
        //            Console.WriteLine("Yetişkin");
        //        }
        //        else if (yas >= 65)
        //        {
        //            Console.WriteLine("Yaşlı");
        //        }
        #endregion
        #region  İsimli Mesaj + Yaş Hesaplama + Yaş Grubu
        //Console.Write("Adınızı girin: ");
        //string ad = Console.ReadLine();

        //Console.Write("Yaşınızı girin: ");
        //int yas = Convert.ToInt32(Console.ReadLine());

        //int dogumYili = DateTime.Now.Year - yas;

        //Console.WriteLine($"\nMerhaba {ad}, {yas} yaşındasın ve doğum yılın {dogumYili}.");

        //if (yas >= 0 && yas <= 6)
        //{
        //    Console.WriteLine("Sen bir bebeksin.");
        //}
        //else if (yas <= 12)
        //{
        //    Console.WriteLine("Sen bir çocuksun.");
        //}
        //else if (yas <= 17)
        //{
        //    Console.WriteLine("Sen bir ergenlik dönemindesin.");
        //}
        //else if (yas <= 30)
        //{
        //    Console.WriteLine("Genç yetişkinsin.");
        //}
        //else if (yas <= 64)
        //{
        //    Console.WriteLine("Yetişkin bir bireysin.");
        //}
        //else
        //{
        //    Console.WriteLine("Emeklilik yaşındasın.");
        //}

        #endregion,
        #region Döngü ile Tekrar Sorma
        //string cevap;

        //do
        //{ 
        //    Console.Write("Adınızı girin: ");
        //    string ad = Console.ReadLine();

        //    Console.Write("Yaşınızı girin: ");
        //    int yas = Convert.ToInt32(Console.ReadLine());

        //    int dogumYili = DateTime.Now.Year - yas;

        //    Console.WriteLine($"\nMerhaba {ad}, {yas} yaşındasın ve doğum yılın {dogumYili}.");

        //    if (yas >= 0 && yas <= 6)
        //    {
        //        Console.WriteLine("Sen bir bebeksin.");
        //    }
        //    else if (yas <= 12)
        //    {
        //        Console.WriteLine("Sen bir çocuksun.");
        //    }
        //    else if (yas <= 17)
        //    {
        //        Console.WriteLine("Sen bir ergenlik dönemindesin.");
        //    }
        //    else if (yas <= 30)
        //    {
        //        Console.WriteLine("Genç yetişkinsin.");
        //    }
        //    else if (yas <= 64)
        //    {
        //        Console.WriteLine("Yetişkin bir bireysin.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Emeklilik yaşındasın.");
        //    }

        //    Console.WriteLine("\nTekrar denemek ister misiniz? (e/h): ");
        //    cevap = Console.ReadLine();
        //}
        //while (cevap.ToLower() == "e");

        //Console.WriteLine("Programdan çıkılıyor. Güle güle!");

        #endregion
        #region renkli mesajlar
        //string cevap = "e";

        //do
        //{
        //    Console.Write("Adınızı girin: ");
        //    string ad = Console.ReadLine();

        //    int yas;

        //    try
        //    {
        //        Console.Write("Yaşınızı girin: ");
        //        yas = Convert.ToInt32(Console.ReadLine());
        //    }
        //    catch
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("⚠️ Lütfen geçerli bir sayı girin!\n");
        //        Console.ResetColor();
        //        continue;
        //    }

        //    int dogumYili = DateTime.Now.Year - yas;

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine($"\nMerhaba {ad}, {yas} yaşındasın ve doğum yılın {dogumYili}.");
        //    Console.ResetColor();

        //    Console.ForegroundColor = ConsoleColor.Yellow;

        //    if (yas >= 0 && yas <= 6)
        //    {
        //        Console.WriteLine("Sen bir bebeksin.");
        //    }
        //    else if (yas <= 12)
        //    {
        //        Console.WriteLine("Sen bir çocuksun.");
        //    }
        //    else if (yas <= 17)
        //    {
        //        Console.WriteLine("Sen bir ergenlik dönemindesin.");
        //    }
        //    else if (yas <= 30)
        //    {
        //        Console.WriteLine("Genç yetişkinsin.");
        //    }
        //    else if (yas <= 64)
        //    {
        //        Console.WriteLine("Yetişkin bir bireysin.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Emeklilik yaşındasın.");
        //    }

        //    Console.ResetColor();

        //    Console.Write("\nTekrar denemek ister misiniz? (e/h): ");
        //    cevap = Console.ReadLine();
        //}
        //while (cevap.ToLower() == "e");

        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine("\nProgramdan çıkılıyor. Görüşmek üzere!");
        //Console.ResetColor();
    
    #endregion
    #region switch Kullanımı
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir gün seçin:");
        Console.WriteLine("1 - Pazartesi");
        Console.WriteLine("2 - Salı");
        Console.WriteLine("3 - Çarşamba");
        Console.WriteLine("4 - Perşembe");
        Console.WriteLine("5 - Cuma");
        Console.WriteLine("6 - Cumartesi");
        Console.WriteLine("7 - Pazar");

        Console.Write("Seçiminiz: ");
        string secim = Console.ReadLine();

        switch (secim)
        {
            case "1":
                Console.WriteLine("Haftanın ilk günü: Pazartesi");
                break;
            case "2":
                Console.WriteLine("Bugün Salı");
                break;
            case "3":
                Console.WriteLine("Haftanın ortası: Çarşamba");
                break;
            case "4":
                Console.WriteLine("Perşembe günü güzel geçsin!");
                break;
            case "5":
                Console.WriteLine("Cuma: Hafta sonu yaklaşıyor!");
                break;
            case "6":
                Console.WriteLine("Cumartesi: Tatilin tadını çıkar!");
                break;
            case "7":
                Console.WriteLine("Pazar: Dinlenme zamanı.");
                break;
            default:
                Console.WriteLine("Geçersiz seçim yaptınız.");
                break;
        }
    }
}


#endregion



