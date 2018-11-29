using _10_paskaita_2018_11_29.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_paskaita_2018_11_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent zmogus = new Parent("Andrius", "Zakarauskas", "Vilnius");
            zmogus.Vardas();
            zmogus.Pavarde();
            zmogus.Adresas();

            Child zmogus1 = new Child("Vardenis", "Pavardenis", "Liaudarskis");
            zmogus1.Vardas();
            zmogus1.Pavarde();
            zmogus1.Adresas();

            Parent zmogelis = new Child("test", "test1", "test2");

            Antra vienas = new Antra();
            vienas.Labas();
            
            Console.Read();
        }
    }
}
