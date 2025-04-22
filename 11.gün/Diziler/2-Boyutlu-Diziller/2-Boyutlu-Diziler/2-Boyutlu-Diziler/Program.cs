using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
            //    string[,] menu = {
            //    {"Pizza", "Hamburger", "Pasta"},
            //    {"Kola", "Su", "Meyve Suyu"},
            //    {"Çikolatalı Kek", "Dondurma", "Tiramisu"}
            //};

            //    Console.WriteLine("Restoran Menüsü:\n");

            //    // Menüdeki yemekleri yazdırma
            //    for (int i = 0; i < menu.GetLength(0); i++) // Kategoriler
            //    {
            //        Console.WriteLine(i == 0 ? "Yemekler:" : i == 1 ? "İçecekler:" : "Tatlılar:");

            //        for (int j = 0; j < menu.GetLength(1); j++) // Öğünler
            //        {
            //            Console.WriteLine($"  {menu[i, j]}");
            //        }
            //        Console.WriteLine();
            //    }
            #endregion
            #region 2 Boyutlu Dizi ile Toplam, Ortalama Hesaplama
            //int[,] notlar = {
            //    {85, 90, 80},
            //    {78, 88, 92},
            //    {70, 75, 85}
            //};

            //for (int i = 0; i < notlar.GetLength(0); i++) // Her öğrenci
            //{
            //    int toplam = 0;

            //    for (int j = 0; j < notlar.GetLength(1); j++) // Ders notları
            //    {
            //        toplam += notlar[i, j];
            //    }

            //    double ortalama = (double)toplam / notlar.GetLength(1);
            //    Console.WriteLine($"Öğrenci {i + 1} not ortalaması: {ortalama:F2}");
            //}

            #endregion
            #region Küçük Uygulama: Sınıf Tablosu (İsim ve Not)
            //string[] isimler = new string[3];
            //int[,] notlar = new int[3, 2];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Öğrenci {i + 1} ismi: ");
            //    isimler[i] = Console.ReadLine();

            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write($"{isimler[i]} - Not {j + 1}: ");
            //        notlar[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n--- Öğrenci Not Ortalamaları ---");

            //for (int i = 0; i < 3; i++)
            //{
            //    int toplam = 0;
            //    for (int j = 0; j < 2; j++)
            //    {
            //        toplam += notlar[i, j];
            //    }

            //    double ortalama = (double)toplam / 2;
            //    Console.WriteLine($"{isimler[i]}: {ortalama:F2}");
            //}

            #endregion
            #region  Mini Oyun: “Sayı Tahmin Oyunu” (Dizi Versiyonu)
            //        Random rnd = new Random();
            //        int[] rastgeleSayilar = new int[5];

            //        // 1-50 arasında rastgele 5 sayı oluştur
            //        for (int i = 0; i < rastgeleSayilar.Length; i++)
            //        {
            //            rastgeleSayilar[i] = rnd.Next(1, 51); // 1-50 dahil
            //        }

            //        Console.WriteLine("🕹️ Sayı Tahmin Oyununa Hoş Geldin!");
            //        Console.WriteLine("1 ile 50 arasında gizlenmiş 5 sayı var.");
            //        Console.WriteLine("Bu sayılardan birini 3 tahminde bulabilir misin? 🎯");

            //        int tahminHakki = 3;

            //        while (tahminHakki > 0)
            //        {
            //            Console.Write($"\nTahmininizi girin ({tahminHakki} hakkınız kaldı): ");
            //            int tahmin = Convert.ToInt32(Console.ReadLine());

            //            bool dogruMu = false;

            //            foreach (int sayi in rastgeleSayilar)
            //            {
            //                if (tahmin == sayi)
            //                {
            //                    dogruMu = true;
            //                    break;
            //                }
            //            }

            //            if (dogruMu)
            //            {
            //                Console.WriteLine("🎉 Tebrikler! Sayılardan birini bildiniz!");
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("❌ Maalesef, yanlış tahmin.");
            //                tahminHakki--;
            //            }
            //        }

            //        Console.WriteLine("\n🎲 Bilgisayarın sayıları:");
            //        foreach (int s in rastgeleSayilar)
            //        {
            //            Console.Write($"{s} ");
            //        }

            //        Console.WriteLine("\n\nOyun bitti. Teşekkürler!");
            //    }
            //}

            #endregion
            #region Sayı Tahmin Oyunu (İpuculu Versiyon)
            //    Random rnd = new Random();
            //    int[] rastgeleSayilar = new int[5];

            //    // 1-50 arasında rastgele 5 sayı üret
            //    for (int i = 0; i < rastgeleSayilar.Length; i++)
            //    {
            //        rastgeleSayilar[i] = rnd.Next(1, 51);
            //    }

            //    Console.WriteLine("🎯 Sayı Tahmin Oyunu - İpuculu Versiyon");
            //    Console.WriteLine("1 ile 50 arasında gizlenmiş 5 sayı var.");
            //    Console.WriteLine("Bu sayılardan birini 3 tahminde bulmaya çalış!");

            //    int tahminHakki = 3;

            //    while (tahminHakki > 0)
            //    {
            //        Console.Write($"\nTahmininizi girin ({tahminHakki} hakkınız kaldı): ");
            //        int tahmin = Convert.ToInt32(Console.ReadLine());

            //        bool dogruMu = false;

            //        foreach (int sayi in rastgeleSayilar)
            //        {
            //            if (tahmin == sayi)
            //            {
            //                dogruMu = true;
            //                break;
            //            }
            //        }

            //        if (dogruMu)
            //        {
            //            Console.WriteLine("🎉 Tebrikler! Doğru tahmin!");
            //            break;
            //        }
            //        else
            //        {
            //            // En yakın sayıyı bulalım
            //            int enYakinFark = int.MaxValue;
            //            int enYakinSayi = 0;

            //            foreach (int sayi in rastgeleSayilar)
            //            {
            //                int fark = Math.Abs(tahmin - sayi);
            //                if (fark < enYakinFark)
            //                {
            //                    enYakinFark = fark;
            //                    enYakinSayi = sayi;
            //                }
            //            }

            //            // İpucu verelim
            //            if (tahmin < enYakinSayi)
            //            {
            //                Console.WriteLine("🔺 Daha büyük bir sayı dene.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("🔻 Daha küçük bir sayı dene.");
            //            }

            //            tahminHakki--;
            //        }
            //    }

            //    Console.WriteLine("\n🔐 Doğru sayılar şunlardı:");
            //    foreach (int s in rastgeleSayilar)
            //    {
            //        Console.Write($"{s} ");
            //    }

            //    Console.WriteLine("\n\n🎮 Oyun bitti. Tekrar denemek ister misin?");
            //}
            #endregion
            #region Mini Oyun #2: En Büyük Sayıyı Bul
            //int[] sayilar = new int[5];

            //Console.WriteLine("🧮 Lütfen 5 adet sayı girin:");

            //for (int i = 0; i < sayilar.Length; i++)
            //{   
            //    Console.Write($"Sayı {i + 1}: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int enBuyuk = sayilar[0];
            //int enKucuk = sayilar[0];
            //int toplam = 0;

            //foreach (int sayi in sayilar)
            //{
            //    if (sayi > enBuyuk)
            //        enBuyuk = sayi;

            //    if (sayi < enKucuk)
            //        enKucuk = sayi;

            //    toplam += sayi;
            //}

            //double ortalama = (double)toplam / sayilar.Length;

            //Console.WriteLine($"\n📈 En büyük sayı: {enBuyuk}");
            //Console.WriteLine($"📉 En küçük sayı: {enKucuk}");
            //Console.WriteLine($"📊 Ortalama: {ortalama:F2}");

            #endregion
            #region Sayı Hafıza Oyunu
            //int[] bilgisayarSayilari = new int[5];
            //Random rnd = new Random();

            //Console.WriteLine("🧠 Sayı Hafıza Oyunu");
            //Console.WriteLine("5 sayıyı sırayla aklında tut, sonra onları girmeye çalış!");
            //Console.WriteLine("\nHazırsan ENTER'a bas...");
            //Console.ReadLine();

            //// Bilgisayar rastgele 5 sayı üretir
            //for (int i = 0; i < bilgisayarSayilari.Length; i++)
            //{
            //    bilgisayarSayilari[i] = rnd.Next(10, 100); // 2 basamaklı sayılar
            //}

            //Console.WriteLine("\n💡 Sayılar:");
            //foreach (int s in bilgisayarSayilari)
            //{
            //    Console.Write($"{s} ");
            //}

            //Thread.Sleep(4000); // 4 saniye göster
            //Console.Clear(); // Ekranı temizle

            //Console.WriteLine("📝 Şimdi hatırladığın sayıları sırayla gir:");

            //int[] kullaniciTahmin = new int[5];

            //for (int i = 0; i < kullaniciTahmin.Length; i++)
            //{
            //    Console.Write($"Sayı {i + 1}: ");
            //    kullaniciTahmin[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //// Karşılaştırma
            //bool basarili = true;

            //for (int i = 0; i < bilgisayarSayilari.Length; i++)
            //{
            //    if (kullaniciTahmin[i] != bilgisayarSayilari[i])
            //    {
            //        basarili = false;
            //        break;
            //    }
            //}

            //if (basarili)
            //{
            //    Console.WriteLine("🎉 Harika! Hepsini doğru hatırladın!");
            //}
            //else
            //{
            //    Console.WriteLine("❌ Maalesef, bazı sayılar yanlış...");
            //    Console.WriteLine("\n✔️ Doğru dizi:");
            //    foreach (int s in bilgisayarSayilari)
            //        Console.Write($"{s} ");

            //    Console.WriteLine("\n❔ Senin girdiğin:");
            //    foreach (int s in kullaniciTahmin)
            //        Console.Write($"{s} ");
            //}
            #endregion
            #region Kelime Tahmin Oyunu (Word Guess)
            //string[] kelimeler = { "elma", "masa", "kitap", "araba", "kalem", "kedi", "telefon" };
            //Random rnd = new Random();
            //string secilenKelime = kelimeler[rnd.Next(kelimeler.Length)];

            //char[] gorunenKelime = new char[secilenKelime.Length];
            //for (int i = 0; i < gorunenKelime.Length; i++)
            //{
            //    gorunenKelime[i] = '_';
            //}

            //int kalanHak = 6;
            //List<char> kullanilanHarfler = new List<char>();

            //Console.WriteLine("🔤 Kelime Tahmin Oyunu!");
            //Console.WriteLine($"Kelime {secilenKelime.Length} harfli. Toplam 6 yanlış hakkınız var.");

            //while (kalanHak > 0)
            //{
            //    Console.WriteLine($"\nKelime: {new string(gorunenKelime)}");
            //    Console.WriteLine($"Kalan hakkınız: {kalanHak}");
            //    Console.Write("Bir harf tahmin edin: ");
            //    char tahmin = Console.ReadLine().ToLower()[0];

            //    if (kullanilanHarfler.Contains(tahmin))
            //    {
            //        Console.WriteLine("❗ Bu harfi zaten denedin.");
            //        continue;
            //    }

            //    kullanilanHarfler.Add(tahmin);

            //    if (secilenKelime.Contains(tahmin))
            //    {
            //        for (int i = 0; i < secilenKelime.Length; i++)
            //        {
            //            if (secilenKelime[i] == tahmin)
            //            {
            //                gorunenKelime[i] = tahmin;
            //            }
            //        }

            //        if (!new string(gorunenKelime).Contains('_'))
            //        {
            //            Console.WriteLine($"\n🎉 Tebrikler! Kelimeyi buldun: {secilenKelime}");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("❌ Yanlış harf!");
            //        kalanHak--;
            //    }
            //}

            //if (kalanHak == 0)
            //{
            //    Console.WriteLine($"\n😢 Üzgünüm, kaybettin. Doğru kelime: {secilenKelime}");
            //}
            #endregion
            #region Adam asmaca oyunu
            //    string[] kelimeler = { "elma", "araba", "kalem", "telefon", "kedi", "muz", "bilgisayar" };
            //    Random rnd = new Random();
            //    string secilenKelime = kelimeler[rnd.Next(kelimeler.Length)];

            //    char[] gorunen = new char[secilenKelime.Length];
            //    for (int i = 0; i < gorunen.Length; i++)
            //        gorunen[i] = '_';

            //    List<char> kullanilanHarfler = new List<char>();
            //    int hataSayisi = 0;

            //    while (hataSayisi < 6 && new string(gorunen).Contains("_"))
            //    {
            //        Console.Clear();
            //        AsciAdamCiz(hataSayisi);

            //        Console.WriteLine($"\nKelime: {new string(gorunen)}");
            //        Console.WriteLine("Kullanılan harfler: " + string.Join(", ", kullanilanHarfler));
            //        Console.Write("Harf tahmini: ");
            //        char tahmin = Console.ReadLine().ToLower()[0];

            //        if (kullanilanHarfler.Contains(tahmin))
            //        {
            //            Console.WriteLine("❗ Bu harfi zaten kullandın.");
            //            Console.ReadKey();
            //            continue;
            //        }

            //        kullanilanHarfler.Add(tahmin);

            //        if (secilenKelime.Contains(tahmin))
            //        {
            //            for (int i = 0; i < secilenKelime.Length; i++)
            //            {
            //                if (secilenKelime[i] == tahmin)
            //                    gorunen[i] = tahmin;
            //            }
            //        }
            //        else
            //        {
            //            hataSayisi++;
            //        }
            //    }

            //    Console.Clear();
            //    AsciAdamCiz(hataSayisi);

            //    if (hataSayisi == 6)
            //    {
            //        Console.WriteLine($"\n😢 Asıldın! Kelime: {secilenKelime}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\n🎉 Tebrikler! Doğru kelime: {secilenKelime}");
            //    }
            //}

            //static void AsciAdamCiz(int hata)
            //{
            //    string[] adam = new string[7];
            //    adam[0] = "  _______";
            //    adam[1] = " |/      |";
            //    adam[2] = hata > 0 ? " |      ( )" : " |";
            //    adam[3] = hata == 2 ? " |       |" :
            //              hata == 3 ? " |      /|" :
            //              hata >= 4 ? " |      /|\\" : " |";
            //    adam[4] = hata == 5 ? " |      /" :
            //              hata == 6 ? " |      / \\" : " |";
            //    adam[5] = " |";
            //    adam[6] = "_|___";

            //    foreach (string satir in adam)
            //        Console.WriteLine(satir);
            #endregion
            #region Matematik Oyunu (Math Quiz Game)
            //int puan = 0;
            //int toplamSoru = 10;

            //Random rnd = new Random();

            //Console.WriteLine("🧮 Matematik Oyunu Başladı!");
            //Console.WriteLine($"Toplam {toplamSoru} soru var. Her doğru cevap 10 puan.\n");

            //for (int i = 1; i <= toplamSoru; i++)
            //{
            //    int sayi1 = rnd.Next(1, 21); // 1-20 arası
            //    int sayi2 = rnd.Next(1, 21);
            //    string islem;
            //    int sonuc = 0;

            //    if (rnd.Next(2) == 0) // %50 ihtimalle toplama veya çıkarma
            //    {
            //        islem = "+";
            //        sonuc = sayi1 + sayi2;
            //    }
            //    else
            //    {
            //        islem = "-";
            //        sonuc = sayi1 - sayi2;
            //    }

            //    Console.Write($"Soru {i}: {sayi1} {islem} {sayi2} = ");
            //    int cevap;
            //    bool sayiyaDondu = int.TryParse(Console.ReadLine(), out cevap);

            //    if (!sayiyaDondu)
            //    {
            //        Console.WriteLine("❗ Geçersiz giriş, sayı bekleniyordu. 0 puan.\n");
            //        continue;
            //    }

            //    if (cevap == sonuc)
            //    {
            //        Console.WriteLine("✅ Doğru!\n");
            //        puan += 10;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"❌ Yanlış! Doğru cevap: {sonuc}\n");
            //    }
            //}

            //Console.WriteLine($"🎉 Oyun Bitti! Toplam Puanınız: {puan}/{toplamSoru * 10}");
            #endregion

        }
    }
}



    