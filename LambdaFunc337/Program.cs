using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunc337
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Employee> EmpList = new List<Employee>
            {
                new Employee { ID=1, FName="Joe", LName="LastName"},
                new Employee { ID=2, FName="Kevin", LName = "LName2"},
                new Employee { ID=3, FName="Ny", LName = "LName3" },
                new Employee { ID=4, FName="Sera", LName= "LName4"},
                new Employee { ID =5, FName="Lexi", LName= "LName5"},
                new Employee { ID=6, FName="Green", LName="LName6" },
                new Employee { ID=7, FName="Joe", LName="LName7"},
                new Employee { ID=8, FName="AnotherName", LName="LName8"},
                new Employee { ID = 9, FName = "Spacefiller", LName = "LName9" },
                new Employee { ID = 10, FName= "Morename", LName = "LName10"}
            };

            //Using foreach loop to add Joe to a new list of Joes
            List<Employee> Joes = new List<Employee>();
            foreach (Employee emp in EmpList)
            {
                if (emp.FName == "Joe")
                {
                    Joes.Add(emp);
                }
                
            }

            //Same output using Lambda function
            List<Employee> Joes2 = new List<Employee>( EmpList.Where(emp => emp.FName == "Joe"));

            //Output of EmpList to a new List where all ID's greater than 5 are listed
            List<Employee> IDs = new List<Employee>(EmpList.Where(e => e.ID > 5));

        }

        //Creating a List with multiple data-types inside Main() has me a bit thrown for a loop
        public class Employee
        {
            public int ID { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
        }
    }
}
