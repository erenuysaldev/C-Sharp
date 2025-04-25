using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Abstract Class ve Interface Arasındaki Farklar:
Özellik | Abstract Class | Interface
Metotlar | Hem soyut (abstract) hem de somut olabilir. | Sadece soyut metotlar içerir.
Kalıtım | Sadece tek sınıfı miras alabilir. | Birden fazla interface implement edilebilir.
Üyeler | Alanlar, constructorlar ve methodlar olabilir. | Yalnızca metot imzaları ve özellikler olabilir.
Amacı | Ortak davranışları tanımlar ve alt sınıflara sağlar. | Sadece bir "sözleşme" tanımlar.


*/
namespace Abstract
{
    public abstract class Hayvan
    {
        public string Ad { get; set; }

        // Soyut metot
        public abstract void SesCikar();  // Alt sınıflar bu methodu implement etmeli.

        // Normal metot (Alt sınıflar değiştirebilir veya kullanabilir)
        public void Yuru()
        {
            Console.WriteLine($"{Ad} yürüdü.");
        }
    }
    public class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} havladı! ");
        }
    }

    public class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} miyavladı! ");
        }
    }
}
