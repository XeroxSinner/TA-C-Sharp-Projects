using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass302
{
    public abstract class Person
    {
        //Defining properties of Person class
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Defining an abstract method that must be used when this class is inherited from
        public abstract void SayName();

    }
}
