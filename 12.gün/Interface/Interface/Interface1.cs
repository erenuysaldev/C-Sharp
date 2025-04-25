using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICalisan
    {
        void Calis();         // Zorunlu method
        string AdGetir();     // Zorunlu method
    }
    /*
     Interface Özellikleri
✅ Sadece method/property imzası olur
✅ public olarak kabul edilir
✅ Çoklu interface uygulanabilir
✅ Interface'ler bir nevi "sözleşme" gibidir: “Bunu implement eden bu kurallara uyar!”*/
}
