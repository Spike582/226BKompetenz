using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226BKomp.HZ3_K1
{
    class Mensch: Säugetier
    {
        private string beruf;

        private bool verheiratet;

        public void Arbeiten()
        {
            //Arbeit ausführen
        }

        public Mensch(string Name = "", int Age = 0, string Beruf = "", bool Verheiratet = false):base()
        {
            name = Name;
            age = Age;
            beruf = Beruf;
            verheiratet = Verheiratet;
        }
    }
}
