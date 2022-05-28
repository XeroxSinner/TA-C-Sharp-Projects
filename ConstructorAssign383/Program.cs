using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssign383
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee(13);

            const string myName = "Ny";

            Console.WriteLine("Doesn't do much but tell you my name is {0}.", myName);
            Console.ReadLine();
        }

        
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id) : this(id, "None")
        { }
    
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
