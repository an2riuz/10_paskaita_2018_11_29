using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_paskaita_2018_11_29
{
    class Child : Parent
    {
        public Child(string vardas, string pavarde, string adresas) : base(vardas, pavarde, adresas)
        {
        }

        public override void Vardas()
        {
            Console.WriteLine("Child.Vardas()");
        }
        public new void Pavarde()
        {
            Console.WriteLine("Child.Pavarde()");
        }
        public void Adresas()
        {
            Console.WriteLine("Child.Adresas()");
        }
    }
}
