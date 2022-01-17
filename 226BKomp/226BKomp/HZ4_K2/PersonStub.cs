using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226BKomp.HZ4_K2
{
    class PersonStub: IPerson
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsHungry() {

            return false;
        }

        public PersonStub()
        {
            Name = "Peter";
            Age = 20;
        }
    }
}
