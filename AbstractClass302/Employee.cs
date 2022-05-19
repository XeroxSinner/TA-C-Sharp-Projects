using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass302
{
    public class Employee : Person
    {
        //Utilizes abstract method from Person class and defines what it does
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

    }
}
