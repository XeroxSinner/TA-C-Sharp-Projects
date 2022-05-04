using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Calls from Methods class to use here
            Methods methods = new Methods();


            Console.WriteLine("Method Overloading. \nAll using Add method, let's utilize integers. First number please.");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And the second integer please.");
            int numB = Convert.ToInt32(Console.ReadLine());

            int numC = methods.Add(numA, numB);
            Console.WriteLine("Adding them together is: " + numC + "\nNow two floats multiplied, returned as an integer. First number with a decimal please.");
            float numD = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("And the second number with decimal please.");
            float numE = Convert.ToSingle(Console.ReadLine());

            float numF = methods.Add(numD, numE);
            Console.WriteLine("Results: " + numF + ". \nNow to a method to convert string to integer and subract, if possible. \nFirst number please.");

            string numG = Console.ReadLine();
            Console.WriteLine("And number two:");
            string numH = Console.ReadLine();

            int numI = methods.Add(numG, numH);
            Console.WriteLine("Results: " + numI);





            Console.ReadLine();    
        }
    }
}
