using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226BKomp.HZ3_K1
{
    class Hund: Säugetier
    {
        private string fellFarbe { get; set; }

        private string rasse { get; set; }

        public void Bellen()
        {
            //Bellen
        }

        public Hund(string Name = "", int Age = 0, string FellFarbe = "", string Rasse = ""):base()
        {
            name = Name;
            age = Age;
            fellFarbe = FellFarbe;
            rasse = Rasse;
        }
    }
}
