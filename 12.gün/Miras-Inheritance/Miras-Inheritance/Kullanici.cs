using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras_Inheritance
{
    public class Kullanici
    {
        public string Ad { get; set; }
        public void GirisYap()
        {
            Console.WriteLine($"{Ad} giriş yaptı.");
        }
    }

    public class Musteri : Kullanici
    {
        public void SiparisVer()
        {
            Console.WriteLine($"{Ad} sipariş verdi.");
        }
    }

    public class Yonetici : Kullanici
    {
        public void RaporGoruntule()
        {
            Console.WriteLine($"{Ad} raporu görüntüledi.");
        }
    }
}
