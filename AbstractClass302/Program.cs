using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calls Employee class with properties inherited from Person class
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //Pulls SayName method, all inherited from Person class and defined in Employee class
            employee.SayName();
            //Calls Quit() from employee, implemented via Employee Class
            employee.Quit();
            Console.ReadLine();

            
            


        }
    }
}
