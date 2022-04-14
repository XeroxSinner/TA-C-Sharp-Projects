using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program \nData from Person 1 and Person 2 will be required. \nPlease use only numbers with or without decimal places. \nPress enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Let's start with Person 1. \nPlease enter the hourly rate. Ex: 32.60");
            double p1HourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Now Person 1's average hours worked per week. Ex: 38");
            double p1HoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Thank you. To confirm, Person 1's hourly rate is $" + p1HourlyRate + " for an average of " + p1HoursWorked + " hours worked.");
            Console.WriteLine("\nOn to Person 2's information. \nPlease enter the hourly rate.Ex: 32.60");
            double p2HourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Now Person 2's average hours worked per week. Ex: 38");
            double p2HoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Thank you. To confirm, Person 2's hourly rate is $" + p2HourlyRate + " for an average of " + p2HoursWorked + " hours worked. \nPress enter to continue.");
            Console.ReadLine();

            double p1Annual = p1HourlyRate * p1HoursWorked * 52;
            double p2Annual = p2HourlyRate * p2HoursWorked * 52;
            Console.WriteLine("Now for a quick comparison of annual salaries: \nPerson 1: $" + p1Annual);
            Console.WriteLine("Person 2: $" + p2Annual);
            bool p1p2Compare = p1Annual > p2Annual;
            if (p1p2Compare == true)
            {
                Console.WriteLine("Person 1 has a higher salary than Person 2. \nPress enter to close.");
            }
            else if (p1p2Compare == false)
            {
                Console.WriteLine("Person 1 has a lower salary than Person 2. \nPress enter to close.");
            }
            Console.ReadLine();
        }
    }
}
