using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass302
{
    public class Employee : Person, IQuittable
    {
        //Utilizes abstract method from Person class and defines what it does
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }


        public void Quit()
        {
            //Body for Quittable interface provided here
            Console.WriteLine("I quit.");
        }

        public int ID { get; set; }


        //overriding == and !=
        public static bool operator ==(Employee a, Employee b)
        {
            return a.ID == b.ID;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return a.ID != b.ID;
        }




    }
}
