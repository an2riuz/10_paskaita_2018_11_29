using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_paskaita_2018_11_29
{
    class Parent
    {
        private string vardas;
        private string pavarde;
        private string adresas;
        

        public Parent(string vardas, string pavarde, string adresas)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.adresas = adresas;
        }
        public virtual void Vardas()
        {
            Console.WriteLine("Jusu vardas: " + vardas);
        }
        public void Pavarde()
        {
            Console.WriteLine("Jusu pavarde: " + pavarde);
        }
        public void Adresas()
        {
            Console.WriteLine("Jusu adresas: " + adresas);
        }
    }
}
