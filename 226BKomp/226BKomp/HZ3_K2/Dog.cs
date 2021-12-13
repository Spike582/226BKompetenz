using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226BKomp.HZ3_K2
{
    class Dog: Saeugetier
    {
        public override int Eat()
        {
            return Hunger -= 2; 
        }
    }
}
