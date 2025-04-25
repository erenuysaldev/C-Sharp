using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras_Inheritance
{
    internal class Program
    {
        static void Main()
        {
            Musteri m = new Musteri();
            m.Ad = "Ali";
            m.GirisYap();      // Miras alınan method
            m.SiparisVer();    // Kendi methodu

            Yonetici y = new Yonetici();
            y.Ad = "Ayşe";
            y.GirisYap();       // Miras
            y.RaporGoruntule(); // Kendi methodu
            Kopek kopek = new Kopek();
            kopek.Ad = "Karabaş";
            kopek.SesCikar(); // Kalıtımdan gelir
            kopek.Havla();    // Kendine özel

            Kedi kedi = new Kedi();
            kedi.Ad = "Tekir";
            kedi.SesCikar();  // Kalıtımdan gelir
            kedi.Miyavla();   // Kendine özel
            Araba araba = new Araba { Marka = "BMW" };
            araba.Calistir();
            araba.CamAc();

            Motosiklet motor = new Motosiklet { Marka = "Yamaha" };
            motor.Calistir();
            motor.TekTeker();
        }
    }
}
