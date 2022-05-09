using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment285
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            


            Console.WriteLine("Input a number, we'll divide it by two: ");
            double a = Convert.ToDouble(Console.ReadLine());

            methods.Half(a);

            string b = "I'm not sure ";
            string c = "what's entirely happening.";
            string s = methods.Add(b, c);
            Console.WriteLine(s);

            Methods2.Names();
            Console.WriteLine(Methods2.fName + " " + Methods2.lName);





            Console.ReadLine();
        }
    }
}
