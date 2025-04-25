using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras_Inheritance
{
    //public class Hayvan
    //{
    //    public string Ad { get; set; }

    //    public void SesCikar()
    //    {
    //        Console.WriteLine($"{Ad} bir ses çıkardı.");
    //    }
    //}

    //public class Kopek : Hayvan
    //{
    //    public void Havla()
    //    {
    //        Console.WriteLine($"{Ad} havladı: Hav hav!");
    //    }
    //}

    //public class Kedi : Hayvan
    //{
    //    public void Miyavla()
    //    {
    //        Console.WriteLine($"{Ad} miyavladı: Miyav!");
    //    }
    //}

    /*virtual: Base sınıfta methodun değiştirilebilir olduğunu söyler.
     override: Alt sınıfta bu methodu özelleştirir.
     new ile method gizleme
     Eğer virtual/override kullanmak istemezsek ama aynı isimde başka bir method yazarsak, C# uyarır ve new keyword'ü ister.
    virtual	Base sınıfta	"Bu method değiştirilebilir" demek
    override	Alt sınıfta	Methodu özelleştirir
    new	Alt sınıfta	Methodu gizler ama virtual/override kadar güvenli değildir
    */
    public class Hayvan
    {
        public string Ad { get; set; }

        public virtual void SesCikar()
        {
            Console.WriteLine($"{Ad} genel bir ses çıkardı.");
        }
    }

    public class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} havladı! 🐶");
        }
    }

    public class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} miyavladı! 🐱");
        }
    }

}
