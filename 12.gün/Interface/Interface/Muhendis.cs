using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Muhendis : ICalisan
    {
        public void Calis()
        {
            Console.WriteLine("Mühendis çalışıyor.");
        }
        public string AdGetir()
        {
            return "Ali Mühendis";
        }
    }
    public class Isci : ICalisan
    {
        public void Calis()
        {
            Console.WriteLine("İşçi çalışıyor.");
        }
        public string AdGetir()
        {
            return "Veli İşçi";
        }
    }
}
