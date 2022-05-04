using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalVariableMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calls method from Methods class
            Methods methods = new Methods();

            //Asking for input and assigning int variables
            Console.WriteLine("Add two numbers, the second is optional and will default to 2 if left blank. \nFirst number please:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number, if desired, please: ");
            int b;
            //Below statement: if string is valid input, convert otherwise b = 0
            if (!int.TryParse(Console.ReadLine(), out b)) b = 2;

            //I don't feel like this is correct, because the 'optional' variable is still being assigned.
            //It 'works' but requires both the if statement and the method to both be changed to match.


            int c = methods.Add(a, b);
            Console.WriteLine("Your answer is: " + c + ".");
            Console.ReadLine();
        }
    }
}
