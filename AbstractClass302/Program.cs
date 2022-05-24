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

            //Instantiate Emp1 and 2 for comparisons
            Employee emp1 = new Employee();
            emp1.ID = 12;
            Employee emp2 = new Employee();
            emp2.ID = 13;

            //Calls overloaded == and writes to console
            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp2 == employee);
            Console.ReadLine();


        }
    }
}
