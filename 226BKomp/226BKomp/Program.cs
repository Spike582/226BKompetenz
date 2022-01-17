using System;

namespace _226BKomp
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        //HZ1 K3

        //fachliche Klassen:
        //in diesen Klassen werden dinge definiert.
        public class Bankaccount                   
        {
            public int Money { get; set; }
        }

        public class Customer
        {
            public string Name{ get; set; }
            public int CashMoney { get; set; }
        }
        //technische Klassen:
        //In diesen Klassen wird etwas ausgeführt.
        
        public class Bank
        {
            public void PayIn(Bankaccount bankaccount, Customer customer, int PayinAmount)
            {
                bankaccount.Money += PayinAmount;
                customer.CashMoney -= PayinAmount;
            }

            public void PayOut(Bankaccount bankaccount, Customer customer, int PayOutAmount)
            {
                bankaccount.Money -= PayOutAmount;
                customer.CashMoney += PayOutAmount;
            }
        }
        //HZ1 K4
        //Keine Switch artige strucktur und dies mit Vererbung umgehen überklasse mit einer "virtuellen" Funktion und die Switch artige strucktur zu umgehen.

        public abstract class Automobile
        {

            public virtual void changeTires()
            {
                Console.WriteLine("Tires changed");
            }
            
        }

        public class Mercedes: Automobile
        {
            public override void changeTires()
            {
                //specific code for changing a Mercedes Tire
                Console.WriteLine("Tires of a mercedes changed");
            }
        }

        public class Mazda: Automobile
        {
            public override void changeTires()
            {
                //specific code for changing a Mazda Tire
                Console.WriteLine("Tires of a matda changed");
            }
        }


    }
}
