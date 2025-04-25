using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras_Inheritance
{
    public class Hayvan
    {
        public string Ad { get; set; }

        public void SesCikar()
        {
            Console.WriteLine($"{Ad} bir ses çıkardı.");
        }
    }

    public class Kopek : Hayvan
    {
        public void Havla()
        {
            Console.WriteLine($"{Ad} havladı: Hav hav!");
        }
    }

    public class Kedi : Hayvan
    {
        public void Miyavla()
        {
            Console.WriteLine($"{Ad} miyavladı: Miyav!");
        }
    }
}
