using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226BKomp.HZ4_K1
{
    class Person
    {
        public IAnimal Animal { get; set; }

        public void getACat()
        {
            Animal = new Cat();
        }
    }
}
