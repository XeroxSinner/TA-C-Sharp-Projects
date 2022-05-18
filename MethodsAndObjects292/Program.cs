using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects292
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calls Employee class with properties inherited from Person class
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Pulls SayName method, all inherited from Person class
            employee.SayName();
            Console.ReadLine();
        }
    }
}
