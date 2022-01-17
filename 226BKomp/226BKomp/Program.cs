using System;

namespace _226BKomp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person();
            Car car = new Car();
            Dirt dirt = new Dirt();

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
        //In this example you can just call the delete Object function and it will "remove" the correct object, this means it will remove the one where it gets called in.

        public class baseClass
        {
            private string Class;
            //These 3 Methodes are there to remove there specific Objekt with things in it witch just that object has (in a real scenaria now theres nothing written in them)
            public void die()
            {
                //Is used to "remove" the person Object  
            }
            public void destroy()
            {
                //Is used to "remove" the car Object  
            }
            public void remove()
            {
                //Is used to "remove" the dirt Object  
            }
            public void deleteObjekt()
            {
                switch (Class)
                {
                    case "Person":
                        Console.WriteLine("The Deleted Class is: Person");
                        //this Metode will do specific code only to destroy a Person object.
                        die();
                        break;

                    case "Car":
                        Console.WriteLine($"The Deleted Class is: Car");
                        //this Metode will do specific code only to destroy a Car object.
                        destroy();
                        break;
                        
                    case "Dirt":
                        Console.WriteLine($"The Deleted Class is: Dirt");
                        //this Metode will do specific code only to destroy a Dirt object.
                        remove();
                        break;

                    default:
                        Console.WriteLine($"this class has not been implemented yet: {Class}.");
                        break;
                }
            }
            public baseClass()
            {
                this.Class = this.GetType().Name;
            }
        }

        public class Person: baseClass
        {
            public Person()
            {
                deleteObjekt();
            }
        }

        public class Car: baseClass
        {
            public Car()
            {
                deleteObjekt();
            }
        }

        public class Dirt: baseClass
        {
            public Dirt()
            {
                deleteObjekt();
            }
        }
    }
}
