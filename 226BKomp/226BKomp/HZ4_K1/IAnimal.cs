using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226BKomp.HZ4_K1
{
    interface IAnimal
    {
        public string owner { get; set; }

        public void Meeow();
    }
}
