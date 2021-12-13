using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226BKomp.HZ3_K2
{
    class Person: Saeugetier
    {
        public override int Eat()
        {
            Hunger--;

            if(Hunger <= 0)
            {
                return Hunger = 0;
            }

            return Hunger;
        }
    }
}
