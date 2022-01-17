using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226BKomp.HZ4_K1
{
    class Cat: IAnimal
    {
        public string owner { get; set; }
        public void Meeow()
        {
            Console.WriteLine("The Cat is Meeowing");
        }
    }
}
