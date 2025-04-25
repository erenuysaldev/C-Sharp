using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan h1 = new Kopek { Ad = "Karabaş" };
            Hayvan h2 = new Kedi { Ad = "Tekir" };

            h1.SesCikar();  // Kopek havladı! 
            h2.SesCikar();  // Kedi miyavladı! 

            h1.Yuru();      // Kopek yürüdü.
            h2.Yuru();      // Kedi yürüdü.
        }
    }
}
