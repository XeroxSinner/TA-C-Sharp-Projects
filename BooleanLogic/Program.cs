using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Input for client's age, converts string to int
            Console.WriteLine("Basic Car Ins. questions using Boolean logic. \nWhat is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //Input for DUI - must utilize 'true' or 'false' for string, converts to bool
            Console.WriteLine("Have you ever had a DUI? Please use true or false.");
            bool dui = Convert.ToBoolean(Console.ReadLine().ToLower());

            //Input for tickets, converts to int
            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());

            //Simple if/else to verify the three requirements
            if (age > 15 && dui == false && ticket < 4)
            {
                Console.WriteLine("Eligible.");
            }
            else
            {
                Console.WriteLine("Ineligible.");
            }
            Console.ReadLine();
        }
    }
}
