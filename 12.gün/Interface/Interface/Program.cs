using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalisan m1 = new Muhendis();
            ICalisan i1 = new Isci();

            m1.Calis();
            Console.WriteLine(m1.AdGetir());

            i1.Calis();
            Console.WriteLine(i1.AdGetir());
        }
    }
}
