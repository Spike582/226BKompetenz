using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226BKomp.HZ3_K2
{
    abstract class Mammal
    {
        public string Name { get; set; }

        public int Hunger { get; set; }

        abstract public int Eat();

    }
}
