using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miras_Inheritance;

namespace Miras_Inheritance
{
    public class Arac
    {
        public string Marka { get; set; }

        public void Calistir()
        {
            Console.WriteLine($"{Marka} çalıştırıldı.");
        }
    }

    public class Araba : Arac
    {
        public void CamAc()
        {
            Console.WriteLine($"{Marka} camı açıldı.");
        }
    }

    public class Motosiklet : Arac
    {
        public void TekTeker()
        {
            Console.WriteLine($"{Marka} tek teker üstünde gidiyor!");
        }
    }
}